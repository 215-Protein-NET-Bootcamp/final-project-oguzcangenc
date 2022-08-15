using AutoMapper;
using CarPartsMarketplace.Business.Adapters.EmailService.Abstract;
using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;
using CarPartsMarketplace.Business.BackgroundJobs;
using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Business.Validation.FluentValidation;
using CarPartsMarketplace.Core.Aspects.Autofac.Logging;
using CarPartsMarketplace.Core.Aspects.Autofac.Performance;
using CarPartsMarketplace.Core.Aspects.Autofac.Validation;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Core.Utilities.Security.Hashing;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Asn1.Ocsp;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly ITokenHelper _tokenHelper;
        private readonly IMapper _mapper;
        private readonly IUserService _applicationUserService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBackgroundJobClient _backgroundJobClient;

        public AuthService(IUserService applicationUserService, ITokenHelper tokenHelper, IMapper mapper,
            IUnitOfWork unitOfWork, IMailService mailService, IBackgroundJobClient backgroundJobClient,
            ISendMailJob sendMailJob)
        {
            _applicationUserService = applicationUserService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _backgroundJobClient = backgroundJobClient;
        }
        public IDataResult<AccessToken> CreateAccessToken(ApplicationUser user)
        {
            var accessToken = _tokenHelper.CreateToken<AccessToken>(user);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.TOKEN_GENERATE);
        }

        public async Task<IResult> UserExists(string mail)
        {
            var result = await _applicationUserService.GetByMail(mail);
            if (result.Success)
            {
                return new ErrorResult(Messages.USER_ALREADY_EXISTS);
            }

            return new SuccessResult(Messages.USER_NOTFOUND);
        }

        /// <summary>
        /// Login User Service
        /// </summary>
        /// <param name="userForLoginDto"></param>
        /// <returns></returns>
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(UserForLoginDtoValidator))]
        [PerformanceAspect(2)]
        public async Task<IDataResult<AccessToken>> Login(UserLoginDto userForLoginDto)
        {
            var userToCheck = await _applicationUserService.GetByMail(userForLoginDto.Email);
            if (!userToCheck.Success)
            {
                return new ErrorDataResult<AccessToken>(Messages.USER_NOTFOUND);
            }

            if (!userToCheck.Data.EmailConfirmation)
            {
                return new ErrorDataResult<AccessToken>(Messages.EMAIL_NOT_CONFIRMED);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash,
                    userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<AccessToken>(Messages.PASSWORD_INCORRECT);
            }

            var resultToken = CreateAccessToken(userToCheck.Data);
            if (resultToken.Success)
            {
                return new SuccessDataResult<AccessToken>(resultToken.Data, Messages.LOGIN_SUCCESS);
            }

            return new ErrorDataResult<AccessToken>(Messages.SYSTEM_ERROR);

        }

        /// <summary>
        /// Register Service
        /// </summary>
        /// <param name="userForRegisterDto"></param>
        /// <returns></returns>
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(UserForRegisterDtoValidator))]
        public async Task<IDataResult<ApplicationUserDto>> Register(UserForRegisterDto userForRegisterDto, HostString host)
        {
            var userExist = await UserExists(userForRegisterDto.Email);
            if (userExist.Success)
            {
                var user = _mapper.Map<ApplicationUser>(userForRegisterDto);
                HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out byte[]? passwordHash,
                    out byte[]? passwordSalt);
                user.LastActivity = DateTime.UtcNow;
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.EmailConfirmation = false;
                user.ModifiedDate = DateTime.UtcNow;
                await _applicationUserService.AddAsync(user);
                HashingHelper.MD5Hash(user.Email, out string emailMd5);
                _backgroundJobClient.Enqueue<ISendMailJob>(job => job.SendMail(new MailRequest()
                {
                    Body =
                        $"Sayın {user.FirstName} {user.LastName}  Car Parts Marketplace'e Hoşgeldiniz. Hesabınızı Doğrulamak için linke tıklayınız. \n" +
                        $"<a href='{"https://" + host + "/api/auth/emailconfirmation?EmailHash="+emailMd5+"&Email="+user.Email}'>Doğrulama Linki</a>",
                    Subject = "Car Parts Marketplace Hoşgeldiniz.",
                    ToEmail = user.Email
                }));

                return new SuccessDataResult<ApplicationUserDto>(_mapper.Map<ApplicationUserDto>(user),
                    Messages.REGISTER_USER_SUCCESSFULY);
            }

            return new ErrorDataResult<ApplicationUserDto>(Messages.USER_ALREADY_EXISTS);

        }

        /// <summary>
        /// Email Confirmation Service
        /// </summary>
        /// <param name="userEmailConfirmationDto"></param>
        /// <returns></returns>
        [LogAspect(typeof(FileLogger))]
        public async Task<IResult> EmailConfirmation(UserEmailConfirmationDto userEmailConfirmationDto)
        {
            HashingHelper.MD5Hash(userEmailConfirmationDto.Email, out string emailMd5);
            if (emailMd5 == userEmailConfirmationDto.EmailHash)
            {
                var user = await _applicationUserService.GetByMail(userEmailConfirmationDto.Email);
                user.Data.EmailConfirmation = true;
                _applicationUserService.Update(user.Data);
                await _unitOfWork.CompleteAsync();

                return new SuccessResult(Messages.EMAIL_CONFIRMED);
            }
            return new ErrorResult(Messages.EMAIL_NOT_CONFIRMED);

        }
    }
}