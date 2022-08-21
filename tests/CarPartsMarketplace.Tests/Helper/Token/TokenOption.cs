using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Tests.Helper.Token
{
    public static class TokenOption
    {
        public static TokenOptions GetTokenOptions()
        {
            TokenOptions tokenOptions = new()
            {
                AccessTokenExpiration = 10,
                Audience = "www.oguzcangenc.com",
                Issuer = "www.oguzcangenc.com",
                SecurityKey = "!z2x3C4v5B*_*!z2x3C4v5B*_*"
            };

            return tokenOptions;
        }
    }
}
