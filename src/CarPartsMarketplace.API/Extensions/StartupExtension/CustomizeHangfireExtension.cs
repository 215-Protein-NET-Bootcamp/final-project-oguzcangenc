using Hangfire;
using Hangfire.PostgreSql;

namespace CarPartsMarketplace.API.Extensions.StartupExtension
{
    public static class CustomizeHangfireExtension
    {
        public static void AddCustomizeHangfire(this IServiceCollection services, WebApplicationBuilder builder,string connectionString)
        {
            services.AddHangfire(x =>
                {
                    x.UsePostgreSqlStorage(builder.Configuration.GetConnectionString(connectionString));
                }
            );

        }
    }
}
