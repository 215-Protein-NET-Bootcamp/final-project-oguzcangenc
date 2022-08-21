using System.Text.Json.Serialization;
using Autofac.Extensions.DependencyInjection;
using CarPartsMarketplace.API.Extensions.StartupExtension;
using CarPartsMarketplace.API.Middleware;
using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;
using CarPartsMarketplace.Business.DependencyResolvers.Autofac;
using CarPartsMarketplace.Business.Services.Redis;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using CarPartsMarketplace.Core.DependencyResolvers;
using CarPartsMarketplace.Core.Extensions;
using CarPartsMarketplace.Data.Context.EntityFramework;
using Hangfire;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Host.UseSerilogExtension();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.UseAutofacConfigureContainer(new BusinessModule());

builder.Services.AddCustomizeHangfire(builder, connectionString: "DefaultConnection");

builder.Services.AddDbContextDependencyInjection<AppDbContext>(builder, connectionString: "DefaultConnection");

builder.Services.AddRedisDependencyInjection(builder.Configuration);

builder.Services.AddHangfireServer();

builder.Services.AddCustomSwaggerExtension();

builder.Services.AddJwtConfigurationService(builder);

builder.Services.AddDependencyResolvers(builder.Configuration, new ICoreModule[] { new CoreModule() });

builder.Services.Configure<FileLogConfiguration>(builder.Configuration.GetSection("FileLogConfiguration"));

builder.Services.Configure<RedisConfiguration>(builder.Configuration.GetSection("Redis"));

builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));

builder.Services.AddCustomizeCors("corsapp");

builder.Services.AddAutoMapperDependecyInjection(builder);

ServiceTool.ServiceProvider = builder.Services.BuildServiceProvider();

var app = builder.Build();

app.UseSwagger();

app.UseCustomizeSwaggerUI();

app.UseCors("corsapp");

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseCustomizeHangfireDashboard("/hangfire-server");

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseMiddleware<HeartbeatMiddleware>();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();