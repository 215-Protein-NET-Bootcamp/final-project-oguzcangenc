using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.Security.Encyption;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CarPartsMarketplace.Core.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        private readonly IOptions<TokenOptions> _tokenOptions;
        private DateTime _accessTokenExpiration;

        public JwtHelper(IOptions<TokenOptions> tokenOptions)
        {
            _tokenOptions = tokenOptions;
        }
        
        public string DecodeToken(string input)
        {
            var handler = new JwtSecurityTokenHandler();
            if (input.StartsWith("Bearer "))
            {
                input = input.Substring("Bearer ".Length);
            }

            return handler.ReadJwtToken(input).ToString();
        }

        public TAccessToken CreateToken<TAccessToken>(User user)
            where TAccessToken : IAccessToken, new()
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.Value.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.Value.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions.Value, user, signingCredentials);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new TAccessToken()
            {
                Token = token,
                Expiration = _accessTokenExpiration,
                RefreshToken = GenerateRefreshToken()
            };
        }

        public JwtSecurityToken CreateJwtSecurityToken(
            TokenOptions tokenOptions,
            User user,
            SigningCredentials signingCredentials)
        {
            var jwt = new JwtSecurityToken(
                tokenOptions.Issuer,
                tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user),
                signingCredentials: signingCredentials);
            return jwt;
        }
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];

            using var generator = new RNGCryptoServiceProvider();
            generator.GetBytes(randomNumber);

            return Convert.ToBase64String(randomNumber);
        }
        private IEnumerable<Claim> SetClaims(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            var claims = new List<Claim>
            {
                new Claim(ClaimConstant.ApplicationUserId, user.Id.ToString())
            };

            foreach (var role in user.UserOperationClaims)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.OperationClaim.Name));
            }
            return claims;
        }

    }
}