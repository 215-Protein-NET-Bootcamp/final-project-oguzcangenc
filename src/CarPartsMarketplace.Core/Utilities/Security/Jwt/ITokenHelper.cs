using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        TAccessToken CreateToken<TAccessToken>(User user) where TAccessToken : IAccessToken, new();

        string GenerateRefreshToken();
    }
}