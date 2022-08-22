using Xunit;
using CarPartsMarketplace.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Tests
{
    public class RelateTextTests
    {
        [Fact()]
        public void RemoveSpaceCharacterTest()
        {
            var result = "       Oğuzcan Genç            ".RemoveSpaceCharacter();

            Assert.Equal(result, "Oğuzcan Genç");
        }

        [Fact()]
        public void ConcatenateWithCommaTest()
        {
            List<int> ints = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12
            };

            var result = ints.ConcatenateWithComma();

            Assert.Equal(result, "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }
    }
}