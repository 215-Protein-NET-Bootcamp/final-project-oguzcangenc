using CarPartsMarketplace.Core.CrossCuttingConcerns.Caching;
using CarPartsMarketplace.Core.DependencyResolvers;
using CarPartsMarketplace.Core.Utilities.Interceptors;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;

namespace CarPartsMarketplace.Core.Aspects.Autofac.Caching;

public class CacheRemoveAspect : MethodInterception
{
    private string _pattern;
    private readonly ICacheManager _cacheManager;

    public CacheRemoveAspect(string pattern)
    {
        _pattern = pattern;
        _cacheManager = DependencyResolvers.ServiceTool.ServiceProvider.GetService<ICacheManager>();
    }
    protected override void OnSuccess(IInvocation invocation)
    {
        _cacheManager.RemoveByPattern(_pattern);
    }

}