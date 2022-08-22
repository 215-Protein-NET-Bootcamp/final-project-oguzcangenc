using Xunit;
using CarPartsMarketplace.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace CarPartsMarketplace.Core.Extensions.Tests
{
    public class ClaimsPrincipalExtensionsTests
    {
        [Fact()]
        public void ClaimsTest()
        {
            var claims = new List<Claim>()
              {
                 new Claim(ClaimTypes.Name, "username"),
                 new Claim(ClaimTypes.NameIdentifier, "userId"),
                 new Claim("name", "John Doe"),
              };
            var identity = new ClaimsIdentity(claims, "TestAuthType");
            var claimsPrincipal = new ClaimsPrincipal(identity);


            var list = ClaimsPrincipalExtensions.Claims(claimsPrincipal, "Admin");

            Assert.IsType<List<string>>(list);
        }
    }
}