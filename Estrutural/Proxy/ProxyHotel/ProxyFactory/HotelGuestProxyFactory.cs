using Castle.DynamicProxy;
using Proxy.Domain;
using Proxy.Domain.Interfaces;

namespace Proxy.ProxyProtection;

/// <summary>
/// Factory class for creating protected hotel guest proxies.
/// </summary>
public class HotelGuestProxyFactory
{
    /// <summary>
    /// Creates a protected hotel guest proxy.
    /// </summary>
    /// <returns>The protected hotel guest proxy.</returns>
    public static IHotelPerson CreateProtectedProxy()
    {
        // Create an instance of HotelPerson
        var hotelPerson = new HotelPerson();

        // Create the interceptor for interception
        var interceptor = new HotelStaffInterceptor(hotelPerson);

        // Create the protected proxy
        var generator = new ProxyGenerator();
        return generator.CreateInterfaceProxyWithTarget<IHotelPerson>(hotelPerson, interceptor);
    }
}
