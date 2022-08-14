﻿using System.Diagnostics;
using Autofac.Extras.DynamicProxy;
using Autofac;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Business.Services.Concrete;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Caching;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Caching.Microsoft;
using CarPartsMarketplace.Core.Utilities.Interceptors;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.Concrete;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Concrete;
using Castle.DynamicProxy;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarPartsMarketplace.Business.DependencyResolvers.Autofac
{
    public class BusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<AuthService>().As<IAuthService>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }

   
}
