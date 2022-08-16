using Autofac.Extras.DynamicProxy;
using Autofac;
using CarPartsMarketplace.Business.Adapters.EmailService.Abstract;
using CarPartsMarketplace.Business.Adapters.EmailService.Concrete;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Business.Services.Concrete;
using CarPartsMarketplace.Core.Utilities.Interceptors;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.Concrete;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Concrete;
using Castle.DynamicProxy;
using CarPartsMarketplace.Business.BackgroundJobs.Abstract;
using CarPartsMarketplace.Business.BackgroundJobs.Concrete;
using CarPartsMarketplace.Business.BackgroundJobs.Manager;
using Microsoft.AspNetCore.Http;

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
            builder.RegisterType<MailService>().As<IMailService>().InstancePerDependency();
            builder.RegisterType<SendMailJob>().As<ISendMailJob>().InstancePerLifetimeScope();
            builder.RegisterType<JobManager>().As<IJobManager>().InstancePerLifetimeScope();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }

   
}
