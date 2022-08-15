

using Serilog;

namespace CarPartsMarketplace.API.Extensions.StartupExtension
{
    public static class SerilogExtension
    {
        public static void UseSerilogExtension(this IHostBuilder builder)
        {
            builder.UseSerilog((ctx, lc) => lc
                .WriteTo.Console()
            );

        }
    }
}
