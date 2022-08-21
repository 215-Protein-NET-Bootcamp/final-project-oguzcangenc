using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Core.Utilities.CounterHelper
{
    public interface ICounterHelper
    {
        void Increment();
        int GetAccessFailedCount();
        
    }
}
