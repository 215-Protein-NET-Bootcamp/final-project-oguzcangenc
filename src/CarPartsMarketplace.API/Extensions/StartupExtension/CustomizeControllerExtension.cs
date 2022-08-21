using FluentValidation.AspNetCore;
using System.Reflection;
using System.Text.Json.Serialization;

namespace CarPartsMarketplace.API.Extensions.StartupExtension
{
    public static class CustomizeControllerExtension
    {
        public static void AddCustomizeControllers(this IServiceCollection services)
        {
            services.AddControllers()
    .AddJsonOptions(x =>
    {
        x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    }).AddFluentValidation(c => c.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
