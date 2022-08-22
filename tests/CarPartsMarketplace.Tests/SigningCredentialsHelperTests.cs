using Xunit;
using CarPartsMarketplace.Core.Utilities.Security.Encyption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using CarPartsMarketplace.Tests;

namespace CarPartsMarketplace.Core.Utilities.Security.Encyption.Tests
{
    public class SigningCredentialsHelperTests
    {
        [Fact()]
        public void CreateSigningCredentialsTest()
        {
            SecurityKeyHelperTests securityKeyHelperTests = new();

            SecurityKey securityKey;

            securityKey = securityKeyHelperTests.Create_Security_Key_Test();


            var response = SigningCredentialsHelper.CreateSigningCredentials(securityKey);

            Assert.IsType<SigningCredentials>(response);
        }
    }
}