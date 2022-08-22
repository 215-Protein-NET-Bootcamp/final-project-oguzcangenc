using CarPartsMarketplace.Core.Utilities.Security.Hashing;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Tests.Helper.Token;
using Microsoft.Extensions.Options;
using Moq;

namespace CarPartsMarketplace.Tests
{
    public class HashingHelperTest
    {
        [Theory]
        [InlineData("k6@VCu44H!iTx")]
        [InlineData("cYq#2I$933Nw&")]
        [InlineData("6l2H*5JlUw7uN")]
        [InlineData("&t1yjRRgR54F9")]
        public void Create_Password_Hash_Test(string password)
        {
            HashingHelper.CreatePasswordHash(password, out var passwordHash, out var passwordSalt);

            bool responseBool = HashingHelper.VerifyPasswordHash(password, passwordHash, passwordSalt);

            Assert.Equal(responseBool, true);
        }
        [Theory]
        [InlineData("oguzcangencc@gmail.com")]
        [InlineData("oguzcangencc@hotmail.com")]
        [InlineData("oguzcangencc@cmail.com")]
        [InlineData("oguzcangencc@ssh.com")]
        [InlineData("oguzcangencc@terme.com")]
        public void Create_Md5_Hash_Test(string mail)
        {
           
            var tokenOptions = TokenOption.GetTokenOptions();
            var options = new Mock<IOptions<TokenOptions>>();
            
            options.Setup(x => x.Value).Returns(tokenOptions);
            
            
            HashingHelper.MD5Hash(mail, out var mailMd51,options.Object);

            HashingHelper.MD5Hash(mail, out var mailMd52, options.Object);


            Assert.Equal(mailMd51, mailMd52);

        }
    }
}