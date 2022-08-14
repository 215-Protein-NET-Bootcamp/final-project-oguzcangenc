using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace CarPartsMarketplace.Core.Utilities.Interceptors
{
    /// <summary>
    /// This class is used to intercept methods.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Assembly, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        /// <summary>
        /// 
        /// </summary>
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {
        }
    }
}
