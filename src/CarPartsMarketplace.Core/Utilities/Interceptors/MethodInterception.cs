using Castle.DynamicProxy;

namespace CarPartsMarketplace.Core.Utilities.Interceptors;

public abstract class MethodInterception : MethodInterceptionBaseAttribute
{
    /// <summary>
    /// Method is intercepted before the actual method is executed.
    /// </summary>
    /// <param name="invocation"></param>
    public override void Intercept(IInvocation invocation)
    {
        var isSuccess = true;
        OnBefore(invocation);
        try
        {
            //Method body is executed
            invocation.Proceed();
            var result = invocation.ReturnValue as Task;
            result?.Wait();
        }
        catch (Exception e)
        {
            isSuccess = false;
            OnException(invocation, e);
            throw;
        }
        finally
        {
            if (isSuccess)
            {
                OnSuccess(invocation);
            } }

        OnAfter(invocation);
    }

    /// <summary>
    /// Method is intercepted before the actual method is executed.
    /// </summary>
    /// <param name="invocation"></param>
    protected virtual void OnBefore(IInvocation invocation)
    {
    }
    /// <summary>
    /// Method is intercepted after the actual method is executed.
    /// </summary>
    /// <param name="invocation"></param>
    protected virtual void OnAfter(IInvocation invocation)
    {
    }
    /// <summary>
    /// Method is intercepted when an exception is thrown.
    /// </summary>
    /// <param name="invocation"></param>
    /// <param name="e"></param>
    protected virtual void OnException(IInvocation invocation, Exception e)
    {
    }
    /// <summary>
    /// Method is intercepted when no exception is thrown.
    /// </summary>
    /// <param name="invocation"></param>
    protected virtual void OnSuccess(IInvocation invocation)
    {
    }
}