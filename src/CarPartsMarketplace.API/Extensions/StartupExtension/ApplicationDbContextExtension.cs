using Microsoft.EntityFrameworkCore;

namespace CarPartsMarketplace.API.Extensions.StartupExtension
{
    public static class ApplicationDbContextExtension
    {
        public static void AddDbContextDependencyInjection<TContext>(this IServiceCollection services, WebApplicationBuilder builder,string connectionString) where TContext:DbContext
        {
            builder.Services.AddDbContext<TContext>(opt =>
            {
                opt.UseNpgsql(builder.Configuration.GetConnectionString(connectionString));
            });


        }
    }
}
