using System.Reflection;
using CarPartsMarketplace.Core.Aspects.Autofac.Exception;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using Castle.DynamicProxy;

namespace CarPartsMarketplace.Core.Utilities.Interceptors;

public class AspectInterceptorSelector : IInterceptorSelector
{
    public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
    {
        var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();
        var methodAttributes =
            type.GetMethods()?.Where(p => p.Name == method.Name).FirstOrDefault().GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
        if (methodAttributes != null)
        {
            classAttributes.AddRange(methodAttributes);
        }

        classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));
        return classAttributes.OrderBy(x => x.Priority).ToArray();
    }
}