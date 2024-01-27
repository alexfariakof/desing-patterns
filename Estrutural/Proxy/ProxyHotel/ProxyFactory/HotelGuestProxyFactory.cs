using Castle.DynamicProxy;
using Proxy.Domain;
using Proxy.Domain.Interfaces;

namespace Proxy.ProxyProtection;
public class HotelGuestProxyFactory
{
    public static IHotelPerson CreateProtectedProxy()
    {
        // Criação da instância concreta de HotelPerson
        var hotelPerson = new HotelPerson();

        // Criação do manipulador (handler) de interceptação
        var interceptor = new HotelStaffInterceptor(hotelPerson);

        // Criação do proxy protegido
        var generator = new ProxyGenerator();
        return generator.CreateInterfaceProxyWithTarget<IHotelPerson>(hotelPerson, interceptor);
    }
}