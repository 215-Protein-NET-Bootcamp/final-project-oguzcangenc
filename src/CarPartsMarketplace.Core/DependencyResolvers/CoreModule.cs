using System.Diagnostics;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Caching;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Caching.Microsoft;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarPartsMarketplace.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ITokenHelper, JwtHelper>();
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
            services.AddTransient<FileLogger>();
            services.AddSingleton<Stopwatch>();

        }
    }
}
