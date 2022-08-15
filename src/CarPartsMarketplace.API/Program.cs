using System.Text.Json.Serialization;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using CarPartsMarketplace.API.Middleware;
using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;
using CarPartsMarketplace.Business.DependencyResolvers.Autofac;
using CarPartsMarketplace.Business.Mapping.AutoMapper;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using CarPartsMarketplace.Core.DependencyResolvers;
using CarPartsMarketplace.Core.Extensions;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Data.Context.EntityFramework;
using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHangfire(x =>
    {
        x.UsePostgreSqlStorage(builder.Configuration.GetConnectionString("DefaultConnection"));

    }
);
builder.Services.AddHangfireServer();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
var coreModule = new CoreModule();
builder.Host.ConfigureContainer<ContainerBuilder>(b =>
{
    b.RegisterModule(new BusinessModule());
});

builder.Services.AddDependencyResolvers(builder.Configuration, new ICoreModule[] { coreModule });
//Very Important Code Here
builder.Services.Configure<FileLogConfiguration>(builder.Configuration.GetSection("FileLogConfiguration"));
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MappingProfile());
});
builder.Services.Configure<TokenOptions>(builder.Configuration.GetSection("TokenOptions"));
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));

builder.Services.AddSingleton(mapperConfig.CreateMapper());
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
ServiceTool.ServiceProvider = builder.Services.BuildServiceProvider();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opt =>
    {
        //Hide Schemas
        opt.DefaultModelsExpandDepth(-1);
    });
}

app.UseCors("corsapp");
app.UseHttpsRedirection();
app.UseHangfireServer();
app.UseHangfireDashboard();
app.UseMiddleware<ExceptionMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();
