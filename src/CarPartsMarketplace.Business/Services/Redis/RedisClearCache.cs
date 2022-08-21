using Microsoft.Extensions.Options;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Business.Services.Redis
{
    public class RedisClearCache: IRedisClearCache
    {
        private readonly IOptions<RedisConfiguration> _redisConfiguration;
        public RedisClearCache(IOptions<RedisConfiguration> redisConfiguration)
        {
            _redisConfiguration = redisConfiguration;
        }
        public void RedisCacheClear()
        {
            try
            {
                ConnectionMultiplexer m = ConnectionMultiplexer.Connect(_redisConfiguration.Value.Host+":"+_redisConfiguration.Value.Port+","+"allowAdmin=true");
                var endpoints = m.GetEndPoints();
                var server = m.GetServer(endpoints.First());
                server.FlushDatabase();
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
