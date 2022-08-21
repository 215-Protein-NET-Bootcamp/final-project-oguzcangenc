using CarPartsMarketplace.Core.Utilities.Security.Hashing;

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
    }
}