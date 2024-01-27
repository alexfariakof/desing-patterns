using Castle.DynamicProxy;

namespace Proxy.Domain.Interfaces;
public interface IHotelPerson 
{
    void AccessKitchen();
    void AccessMonitorRoom();
    void ChekIn();
    void ChekOut();
    void Rate();
}
