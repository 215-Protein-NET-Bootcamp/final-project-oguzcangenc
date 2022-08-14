using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace CarPartsMarketplace.Tests.Core.Helpers
{
    public static class MockJwtTokens
    {
        private static readonly JwtSecurityTokenHandler s_tokenHandler = new();
        private static string s_keyString = "!z2x3C4v5B*_*!z2x3C4v5B*_*";

        static MockJwtTokens()
        {
            var SKey = Encoding.UTF8.GetBytes(s_keyString);
            SecurityKey = new SymmetricSecurityKey(SKey);
            SigningCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256Signature);
        }

        public static string Issuer { get; } = "www.oguzcangenc.com";
        public static string Audience { get; } = "www.oguzcangenc.com";
        public static SecurityKey SecurityKey { get; }
        public static SigningCredentials SigningCredentials { get; }

        public static string GenerateJwtToken(IEnumerable<Claim> claims, double value = 5)
        {
            return s_tokenHandler.WriteToken(new JwtSecurityToken(Issuer, Audience, claims, DateTime.UtcNow, DateTime.UtcNow.AddSeconds(value), SigningCredentials));
        }
    }
}
