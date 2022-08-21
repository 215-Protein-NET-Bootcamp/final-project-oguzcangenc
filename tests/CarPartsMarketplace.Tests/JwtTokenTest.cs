using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Tests.Helper.Token;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Tests
{
    public class JwtTokenTest
    {

        [Fact]
        public AccessToken GenerateToken()
        {
            var tokenOpt = new Mock<IOptions<TokenOptions>>();
            tokenOpt.Setup(x => x.Value).Returns(TokenOption.GetTokenOptions());
            var token = new Mock<ITokenHelper>();
            token.Setup(x => x.CreateToken<AccessToken>(It.IsAny<User>())).Returns(new AccessToken());
            //act
            var jwtTokenHelper = new JwtHelper(tokenOpt.Object);
            var crtToken = jwtTokenHelper.CreateToken<AccessToken>(TestUser.GetTestUser());
            //assert
            Assert.IsType<AccessToken>(crtToken);

            return crtToken;
        }
    }
}
