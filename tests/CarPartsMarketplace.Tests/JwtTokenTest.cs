using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Tests
{
    public class JwtTokenTest
    {

        [Fact]
        public void GenerateToken()
        {
            //Arrange
            TokenOptions tokenOptions = new()
            {
                AccessTokenExpiration = 10,
                Audience = "www.oguzcangenc.com",
                Issuer = "www.oguzcangenc.com",
                SecurityKey = "!z2x3C4v5B*_*!z2x3C4v5B*_*"
            };

            User user = new()
            {
                Id = 1,
                FirstName = "Oğuzcan",
                LastName = "Genç",
                Email = "oguzcangencc@hotmail.com"
            };
            List<UserOperationClaim> userOperationClaims = new()
        {
            new UserOperationClaim()
            {
                UserId=1,
                OperationClaim = new OperationClaim{
                Id =1,
                Name="admin"
                },
            OperationClaimId=1
            },
        };

            user.UserOperationClaims = userOperationClaims;

            var tokenOpt = new Mock<IOptions<TokenOptions>>();
            tokenOpt.Setup(x => x.Value).Returns(tokenOptions);
            var token = new Mock<ITokenHelper>();
            token.Setup(x => x.CreateToken<AccessToken>(It.IsAny<User>())).Returns(new AccessToken());
            //act
            var jwtTokenHelper = new JwtHelper(tokenOpt.Object);
            var crtToken = jwtTokenHelper.CreateToken<AccessToken>(user);
            //assert
            Assert.IsType<AccessToken>(crtToken);
        }
    }
}
