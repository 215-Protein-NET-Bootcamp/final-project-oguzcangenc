using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Business.Adapters.RedisService
{
    public class RedisConfiguration
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Password { get; set; }
        public string InstanceName { get; set; }
    }
}
