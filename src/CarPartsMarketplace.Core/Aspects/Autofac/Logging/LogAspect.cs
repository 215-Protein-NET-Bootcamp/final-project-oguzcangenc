using System.Text.Json;
using CarPartsMarketplace.Core.Constants;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging;
using CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;
using CarPartsMarketplace.Core.DependencyResolvers;
using CarPartsMarketplace.Core.Utilities.Interceptors;
using Castle.DynamicProxy;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace CarPartsMarketplace.Core.Aspects.Autofac.Logging
{
    /// <summary>
    /// Logging interceptor class.
    /// </summary>
    public class LogAspect : MethodInterception
    {
        private readonly LoggerServiceBase? _loggerServiceBase;
        private readonly IHttpContextAccessor? _httpContextAccessor;

        public LogAspect(Type loggerService)
        {

            if (loggerService.BaseType != typeof(LoggerServiceBase))
            {
                throw new ArgumentException(Messages.WrongLoggerType);
            }

            _loggerServiceBase = (LoggerServiceBase)ServiceTool.ServiceProvider.GetService(loggerService)!;
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            _loggerServiceBase?.Info(GetLogDetail(invocation));
        }
        /// <summary>
        /// Get Log Detail
        /// </summary>
        /// <param name="invocation"></param>
        /// <returns></returns>
        private string GetLogDetail(IInvocation invocation)
        {
            var logParameters = invocation.Arguments.Select((t, i) => new LogParameter { Name = invocation.GetConcreteMethod().GetParameters()[i].Name, Value = t, Type = t.GetType().Name, }).ToList();

            var logDetail = new LogDetail
            {
                MethodName = invocation.Method.Name,
                Parameters = logParameters,
                User = (_httpContextAccessor.HttpContext == null ||
                        _httpContextAccessor.HttpContext.User.Identity.Name == null)
                    ? "?"
                    : _httpContextAccessor.HttpContext.User.Identity.Name
            };
            return JsonConvert.SerializeObject(logDetail);
        }
    }
}
