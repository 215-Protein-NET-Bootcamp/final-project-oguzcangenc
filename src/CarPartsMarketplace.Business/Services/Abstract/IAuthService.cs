using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<ApplicationUserDto>> Register(UserForRegisterDto userForRegisterDto,HostString host);
        Task<IResult> EmailConfirmation(UserEmailConfirmationDto userEmailConfirmationDto);
        Task<IDataResult<AccessToken>> Login(UserLoginDto userForLoginDto);

    }
}
