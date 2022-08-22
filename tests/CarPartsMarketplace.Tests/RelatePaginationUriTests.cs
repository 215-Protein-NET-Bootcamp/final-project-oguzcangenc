using Xunit;
using CarPartsMarketplace.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CarPartsMarketplace.Core.Utilities.Pagination;

namespace CarPartsMarketplace.Tests
{
    public class RelatePaginationUriTests
    {
        public Mock<IRelatePaginationUri> mock = new Mock<IRelatePaginationUri>();

        [Fact()]
        public void GetPageUriTest()
        {
            //Arrange
            var paginationFilter = new PaginationFilter(1, 2);
            RelatePaginationUri relatePaginationUri = new RelatePaginationUri("foo://example.com:8042/over/there?name=ferret#nose");

            //Act
            var response = relatePaginationUri.GetPageUri(paginationFilter, "localhost");

            //Assert
            Assert.IsType<Uri>(response);

        }
    }
}