using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Entities.Dtos;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<ApplicationUserDto>> Register(UserForRegisterDto userForRegisterDto);
        Task<IResult> UserExists(string mail);
        Task<IDataResult<AccessToken>> Login(UserLoginDto userForLoginDto);

    }
}
