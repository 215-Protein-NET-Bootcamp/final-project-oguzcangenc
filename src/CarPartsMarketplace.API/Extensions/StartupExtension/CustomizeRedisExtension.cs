using StackExchange.Redis;

namespace CarPartsMarketplace.API.Extensions.StartupExtension
{
    public static class CustomizeRedisExtension
    {
        public static void AddRedisDependencyInjection(this IServiceCollection services, IConfiguration Configuration)
        {
            var configurationOptions = new ConfigurationOptions();

            configurationOptions.Password = Configuration["Redis:Password"];
            configurationOptions.AbortOnConnectFail = false;
            configurationOptions.EndPoints.Add(Configuration["Redis:Host"], Convert.ToInt32(Configuration["Redis:Port"]));
            int.TryParse(Configuration["Redis:DefaultDatabase"], out int defaultDatabase);
            configurationOptions.DefaultDatabase = defaultDatabase;
            services.AddStackExchangeRedisCache(options =>
            {
                options.ConfigurationOptions = configurationOptions;

                options.InstanceName = Configuration["Redis:InstanceName"];
            });
        }
    }
}
