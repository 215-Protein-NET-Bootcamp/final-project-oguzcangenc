using System.Text.Json.Serialization;
using Autofac.Extensions.DependencyInjection;
using CarPartsMarketplace.API.Extensions.StartupExtension;
using CarPartsMarketplace.API.Middleware;
using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;
using CarPartsMarketplace.Business.DependencyResolvers.Autofac;
using CarPartsMarketplace.Business.Tools;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using CarPartsMarketplace.Core.DependencyResolvers;
using CarPartsMarketplace.Core.Extensions;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Data.Context.EntityFramework;
using Hangfire;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Host.UseSerilogExtension();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.UseAutofacConfigureContainer(new BusinessModule());
builder.Services.AddCustomizeHangfire(builder, connectionString: "DefaultConnection");
builder.Services.AddDbContextDependencyInjection<AppDbContext>(builder, connectionString: "DefaultConnection");
builder.Services.AddHangfireServer();
builder.Services.AddCustomSwaggerExtension();
builder.Services.AddDependencyResolvers(builder.Configuration, new ICoreModule[] { new CoreModule() });
builder.Services.Configure<FileLogConfiguration>(builder.Configuration.GetSection("FileLogConfiguration"));
builder.Services.Configure<TokenOptions>(builder.Configuration.GetSection("TokenOptions"));
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddCustomizeCors("corsapp");
builder.Services.AddAutoMapperDependecyInjection(builder);
ServiceTool.ServiceProvider = builder.Services.BuildServiceProvider();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{

}
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    if (dataContext.Database.EnsureCreated())
    {
        SeedDatabase.Seed(dataContext);
        Console.WriteLine("-----> Seed Database");
    }
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("corsapp");
app.UseHttpsRedirection();
app.UseCustomizeHangfireDashboard("/hangfire-server");
app.UseMiddleware<ExceptionMiddleware>();
app.UseMiddleware<HeartbeatMiddleware>();
app.UseAuthorization();
app.MapControllers();
app.Run();