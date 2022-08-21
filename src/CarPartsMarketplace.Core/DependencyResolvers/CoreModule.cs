using System.Diagnostics;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Caching;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Caching.Microsoft;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using CarPartsMarketplace.Core.Extensions;
using CarPartsMarketplace.Core.Utilities.CounterHelper;
using CarPartsMarketplace.Core.Utilities.FileHelper.Abstract;
using CarPartsMarketplace.Core.Utilities.FileHelper.Concrete;
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
            services.AddSingleton<ICounterHelper, CounterHelper>();
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
            services.AddSingleton<IFileHelper, FileHelper>();
            services.AddSingleton<IRelatePaginationUri>(o =>
            {
                var accessor = o.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new RelatePaginationUri(uri);
            });
            services.AddTransient<FileLogger>();
            services.AddSingleton<Stopwatch>();
        

        }
    }
}
