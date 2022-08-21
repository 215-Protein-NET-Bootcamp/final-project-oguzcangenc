using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Core.Utilities.CounterHelper
{
    public class CounterHelper : ICounterHelper
    {
        private int AccessFailedCount { get; set; } = 0;
        public int GetAccessFailedCount()
        {
            return AccessFailedCount;
        }

        public void Increment()
        {
            AccessFailedCount++;

            if (AccessFailedCount == 3)
            {
                AccessFailedCount = 0;
            }
        }
    }
}
