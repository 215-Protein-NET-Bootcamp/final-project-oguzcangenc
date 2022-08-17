using AutoMapper;
using CarPartsMarketplace.Business.BackgroundJobs.Abstract;
using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Business.Validation.FluentValidation;
using CarPartsMarketplace.Core.Aspects.Autofac.Logging;
using CarPartsMarketplace.Core.Aspects.Autofac.Performance;
using CarPartsMarketplace.Core.Aspects.Autofac.Validation;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using CarPartsMarketplace.Core.Data.UnitOfWork.Abstract;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Core.Utilities.Security.Hashing;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly ITokenHelper _tokenHelper;
        private readonly IOptions<TokenOptions> _tokenOptions;
        private readonly IMapper _mapper;
        private readonly IUserService _applicationUserService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJobManager _jobManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthService(IUserService applicationUserService,
            ITokenHelper tokenHelper,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IOptions<TokenOptions> tokenOptions, IJobManager jobManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _applicationUserService = applicationUserService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _tokenOptions = tokenOptions;
            _jobManager = jobManager;
            _httpContextAccessor = httpContextAccessor;
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
                return new ErrorDataResult<AccessToken>(Messages.USER_NOTFOUND);

            var user = userToCheck.Data;

            if (!user.EmailConfirmation)
            {
                await _jobManager.RegisterUserActivationMailJobAsync(new RegisterUserWelcomeMailJobDto()
                {
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                }, _httpContextAccessor.HttpContext.Request.Host.Value);
                return new ErrorDataResult<AccessToken>(Messages.EMAIL_NOT_CONFIRMED);
            }



            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {

                if (userToCheck.Data.LockoutEnabled)
                {
                    return new ErrorDataResult<AccessToken>(Messages.USER_LOCKED);
                }

                if (userToCheck.Data.AccessFailedCount == 3)
                {
                    userToCheck.Data.AccessFailedCount = 0;
                    userToCheck.Data.LockoutEnabled = true;
                    await _unitOfWork.CompleteAsync();
                    await _jobManager.AccountLocoutInformaitonMailJob(userToCheck.Data.Email);
                    return new ErrorDataResult<AccessToken>(Messages.USER_LOCKED);
                }

                userToCheck.Data.AccessFailedCount++;
                _applicationUserService.Update(userToCheck.Data);
                await _unitOfWork.CompleteAsync();
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
        /// Account Activation Service
        /// </summary>
        /// <param name="accountActivationDto"></param>
        /// <returns></returns>
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(AccountActivationValidator))]
        public async Task<IResult> AccountActivation(AccountActivationDto accountActivationDto)
        {
            var userExistsCheck = await UserExists(accountActivationDto.Email);

            if (userExistsCheck.Success)
                return new ErrorResult(userExistsCheck.Message);

            var user = await _applicationUserService.GetByMail(accountActivationDto.Email);
            if (!user.Data.LockoutEnabled)
                return new ErrorResult(Messages.ACCOUNT_ALREADY_ACTIVE);

            user.Data.LockoutEnabled = false;
            _applicationUserService.Update(user.Data);
            await _unitOfWork.CompleteAsync();
            await _jobManager.AccountLocoutActivationMailJob(accountActivationDto.Email);
            return new SuccessResult(Messages.ACCOUNT_ACTIVATED);
        }

        /// <summary>
        /// Register Service
        /// </summary>
        /// <param name="userForRegisterDto"></param>
        /// <returns></returns>
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(UserForRegisterDtoValidator))]
        public async Task<IDataResult<ApplicationUserDto>> Register(UserForRegisterDto userForRegisterDto)
        {
            var userExist = await UserExists(userForRegisterDto.Email);

            if (!userExist.Success) return new ErrorDataResult<ApplicationUserDto>(Messages.USER_ALREADY_EXISTS);

            var user = _mapper.Map<ApplicationUser>(userForRegisterDto);
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out byte[]? passwordHash,
                out byte[]? passwordSalt);
            user.LastActivity = DateTime.UtcNow;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.EmailConfirmation = false;
            user.ModifiedDate = DateTime.UtcNow;
            await _applicationUserService.AddAsync(user);
            await _jobManager.RegisterUserActivationMailJobAsync(new RegisterUserWelcomeMailJobDto()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            }, _httpContextAccessor.HttpContext.Request.Host.Value);

            return new SuccessDataResult<ApplicationUserDto>(_mapper.Map<ApplicationUserDto>(user),
                Messages.REGISTER_USER_SUCCESSFULY);

        }

        /// <summary>
        /// Email Confirmation Service
        /// </summary>
        /// <param name="userEmailConfirmationDto"></param>
        /// <returns></returns>
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(EmailConfirmationValidator))]
        public async Task<IResult> EmailConfirmation(UserEmailConfirmationDto userEmailConfirmationDto)
        {
            var userExistsCheck = await UserExists(userEmailConfirmationDto.Email);

            if (userExistsCheck.Success)
                return new ErrorResult(userExistsCheck.Message);

            var user = await _applicationUserService.GetByMail(userEmailConfirmationDto.Email);
            if (user.Data.EmailConfirmation)
                return new SuccessResult(Messages.EMAIL_ALREADY_CONFIRMED);

            HashingHelper.MD5Hash(userEmailConfirmationDto.Email, out string emailMd5, _tokenOptions);
            if (emailMd5 == userEmailConfirmationDto.EmailHash)
            {
                user.Data.EmailConfirmation = true;
                _applicationUserService.Update(user.Data);
                await _unitOfWork.CompleteAsync();

                return new SuccessResult(Messages.EMAIL_CONFIRMED);
            }
            return new ErrorResult(Messages.EMAIL_NOT_CONFIRMED);
        }
    }
}