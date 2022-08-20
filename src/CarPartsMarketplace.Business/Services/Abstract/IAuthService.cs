using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using CarPartsMarketplace.Entities.Dtos.User;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<UserDto>> Register(UserForRegisterDto userForRegisterDto);
        Task<IResult> EmailConfirmation(UserEmailConfirmationDto userEmailConfirmationDto);
        Task<IDataResult<AccessToken>> Login(UserLoginDto userForLoginDto);
        Task<IResult> ChangePassword(UserForChangePasswordDto changePasswordDto);
        Task<IResult> AccountActivation(AccountActivationDto email);
    }
}
