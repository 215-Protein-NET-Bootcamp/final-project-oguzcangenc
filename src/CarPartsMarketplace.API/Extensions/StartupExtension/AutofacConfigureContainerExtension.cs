using Autofac;
using Autofac.Core;

namespace CarPartsMarketplace.API.Extensions.StartupExtension;

public static class AutofacConfigureContainerExtension
{
    public static void UseAutofacConfigureContainer(this IHostBuilder builder, IModule module)
    {
        builder.ConfigureContainer<ContainerBuilder>(c =>
        {
            c.RegisterModule(module);
        });

    }
}