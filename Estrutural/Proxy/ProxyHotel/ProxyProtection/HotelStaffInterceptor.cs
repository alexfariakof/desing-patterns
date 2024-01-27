using Castle.DynamicProxy;
using Proxy.Domain.Interfaces;

namespace Proxy.ProxyProtection;

/// <summary>
/// Interceptor for controlling access to hotel staff methods.
/// </summary>
public class HotelStaffInterceptor : IHotelPersonInterceptor
{
    private readonly IHotelPerson _hotelPerson;

    /// <summary>
    /// Initializes a new instance of the <see cref="HotelStaffInterceptor"/> class.
    /// </summary>
    /// <param name="hotelPerson">The hotel person instance.</param>
    public HotelStaffInterceptor(IHotelPerson hotelPerson)
    {
        _hotelPerson = hotelPerson ?? throw new ArgumentNullException(nameof(hotelPerson));
    }

    /// <summary>
    /// Intercepts the method call to control access.
    /// </summary>
    /// <param name="invocation">The method invocation.</param>
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
            Console.WriteLine($"Disallowed task for hotel staffs: {methodName}");
        }
    }

    // Checks if the method is allowed
    private bool IsAllowedMethod(string methodName)
    {
        return methodName == "AccessKitchen" || methodName == "ChekIn" || methodName == "ChekOut";
    }
}