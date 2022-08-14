using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Serilog;
using CarPartsMarketplace.API.Extensions.StartupExtension;
using CarPartsMarketplace.Business.DependencyResolvers.Autofac;
using CarPartsMarketplace.Business.Mapping.AutoMapper;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using CarPartsMarketplace.Core.DependencyResolvers;
using CarPartsMarketplace.Core.Extensions;
using CarPartsMarketplace.Data.Context.EntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
var coreModule = new CoreModule();

builder.Host.ConfigureContainer<ContainerBuilder>(b =>
{
    b.RegisterModule(new BusinessModule());
});
builder.Host.UseSerilogExtension();
builder.Services.AddDependencyResolvers(builder.Configuration, new ICoreModule[] { coreModule });
//Very Important Code Here
ServiceTool.ServiceProvider = builder.Services.BuildServiceProvider();

var mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MappingProfile());
});

builder.Services.AddSingleton(mapperConfig.CreateMapper());
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
