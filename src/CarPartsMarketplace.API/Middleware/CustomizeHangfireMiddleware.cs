using Hangfire;

namespace CarPartsMarketplace.API.Middleware
{
    public static class CustomizeHangfireMiddleware
    {
        public static void UseCustomizeHangfireDashboard(this IApplicationBuilder app, string serverPath = "/hangfire")
        {
            var options = new DashboardOptions()
            {
                Authorization = new[] { new HangfireAuthorizationFilter() }
            }; app.UseHangfireDashboard(serverPath, options);
        }
    }
}
