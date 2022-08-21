using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Business.Services.Redis
{
    public interface IRedisClearCache
    {
        void RedisCacheClear();
    }
}
