﻿using AutoMapper;
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

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly ITokenHelper _tokenHelper;
        private readonly IMapper _mapper;
        private readonly IUserService _applicationUserService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBackgroundJobClient _backgroundJobClient;
        public AuthService(IUserService applicationUserService, ITokenHelper tokenHelper, IMapper mapper, IUnitOfWork unitOfWork, IMailService mailService, IBackgroundJobClient backgroundJobClient, ISendMailJob sendMailJob)
        {
            _applicationUserService = applicationUserService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _backgroundJobClient = backgroundJobClient;
        }

        public async Task<IResult> ChangePassword(string oldPassword, string newPassword, string confirmNewPassword, int userId)
        {
            var user = (await _applicationUserService.GetById(userId)).Data;
            if (!HashingHelper.VerifyPasswordHash(oldPassword, user.PasswordHash, user.PasswordSalt))
            {
                return new ErrorResult(Messages.OLD_PASSWORD_INCORRECT);

            }
            HashingHelper.CreatePasswordHash(newPassword, out byte[]? passwordHash, out byte[]? passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.ModifiedDate = DateTime.UtcNow;
            var result = _applicationUserService.Update(user);
            await _unitOfWork.CompleteAsync();
            var response = _mapper.Map<ApplicationUserDto>(user);
            if (result.Success)
            {
                return new SuccessDataResult<ApplicationUserDto>(response, Messages.CHANGE_PASSWORD_SUCCESS);

            }
            return new ErrorResult(Messages.CHANGE_PASSWORD_ERROR);

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
                _backgroundJobClient.Enqueue<ISendMailJob>(job => job.SendMail(new MailRequest() { Body = "dENEME Body", Subject = "dENEME Subject", ToEmail = "oguzcangencc@hotmail.com" }));
                return new ErrorDataResult<AccessToken>(Messages.EMAIL_NOT_CONFIRMED);
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
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
        public async Task<IDataResult<ApplicationUserDto>> Register(UserForRegisterDto userForRegisterDto)
        {
            var userExist = await UserExists(userForRegisterDto.Email);
            if (userExist.Success)
            {
                var user = _mapper.Map<ApplicationUser>(userForRegisterDto);
                HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out byte[]? passwordHash, out byte[]? passwordSalt);
                user.LastActivity = DateTime.UtcNow;
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.EmailConfirmation = false;
                user.ModifiedDate = DateTime.UtcNow;
                await _applicationUserService.AddAsync(user);
                return new SuccessDataResult<ApplicationUserDto>(_mapper.Map<ApplicationUserDto>(user), Messages.REGISTER_USER);
            }

            return new ErrorDataResult<ApplicationUserDto>(Messages.USER_ALREADY_EXISTS);

        }
    }
}
