using Castle.DynamicProxy;
using Proxy.Domain.Interfaces;

namespace Proxy.ProxyProtection;
public class HotelGuestInterceptor : IHotelPersonInterceptor
{
    private readonly IHotelPerson _hotelPerson;
    public HotelGuestInterceptor(IHotelPerson hotelPerson)
    {
        _hotelPerson = hotelPerson;
    }
    public void Intercept(IInvocation invocation)
    {
        string methodName = invocation.Method.Name;

        // Verifica se o método é permitido
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

    // Verifica se o método é permitido
    private bool IsAllowedMethod(string methodName)
    {
        return methodName == "AccessMonitorRoom";
    }
}