using CarPartsMarketplace.Core.DependencyResolvers;
using CarPartsMarketplace.Core.Utilities.Interceptors;
using Castle.DynamicProxy;
using Microsoft.AspNetCore.Http;
using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CarPartsMarketplace.Business.Aspect
{

    public class AuthorizationCheck : MethodInterception
    {
        private readonly string[] _roles;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthorizationCheck(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }

            throw new Exception(Messages.AUTHORIZATION_DENIED);
        }
    }
}