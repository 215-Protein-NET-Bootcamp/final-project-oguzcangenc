using Xunit;
using CarPartsMarketplace.Core.Utilities.Security.Encyption;
using Moq;
using CarPartsMarketplace.Tests.Helper.SecurityKey;
using Microsoft.IdentityModel.Tokens;

namespace CarPartsMarketplace.Tests
{
    public class SecurityKeyHelperTests
    {
        [Fact()]
        public SecurityKey Create_Security_Key_Test()
        {
            var response = SecurityKeyHelper.CreateSecurityKey(SecurityKeys.TestSecurirtyKey);

            Assert.IsType<SymmetricSecurityKey>(response);
            return response;
        }
    }
}