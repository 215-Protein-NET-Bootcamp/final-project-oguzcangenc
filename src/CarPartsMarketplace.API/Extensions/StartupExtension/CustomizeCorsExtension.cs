namespace CarPartsMarketplace.API.Extensions.StartupExtension
{
    public static class CustomizeCorsExtension
    {
        public static void AddCustomizeCors(this IServiceCollection services,string corsName)
        {
            services.AddCors(p => p.AddPolicy(corsName, builder =>
            {
                builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
            }));
        }
    }
}
