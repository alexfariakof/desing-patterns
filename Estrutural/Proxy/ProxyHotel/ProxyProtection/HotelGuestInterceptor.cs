using Castle.DynamicProxy;
using Proxy.Domain.Interfaces;

namespace Proxy.ProxyProtection;

/// <summary>
/// Interceptor class for hotel guests.
/// </summary>
public class HotelGuestInterceptor : IHotelPersonInterceptor
{
    private readonly IHotelPerson _hotelPerson;

    /// <summary>
    /// Initializes a new instance of the <see cref="HotelGuestInterceptor"/> class.
    /// </summary>
    /// <param name="hotelPerson">The instance of <see cref="IHotelPerson"/>.</param>
    public HotelGuestInterceptor(IHotelPerson hotelPerson)
    {
        _hotelPerson = hotelPerson;
    }

    /// <summary>
    /// Intercept method for hotel guests.
    /// </summary>
    /// <param name="invocation">The invocation information.</param>
    public void Intercept(IInvocation invocation)
    {
        string methodName = invocation.Method.Name;

        // Check if the method is allowed
        if (IsAllowedMethod(methodName))
        {
            Console.WriteLine($"Allowing access... {methodName}");
            invocation.ReturnValue = invocation.Method.Invoke(_hotelPerson, invocation.Arguments);
        }
        else
        {
            Console.WriteLine($"Disallowed task for hotel guests: {methodName}");
        }
    }

    // Check if the method is allowed
    private bool IsAllowedMethod(string methodName)
    {
        return methodName == "AccessMonitorRoom";
    }
}