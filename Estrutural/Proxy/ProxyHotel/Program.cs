/* Project Refrences => https://medium.com/@snigdhasanat/protection-proxy-design-pattern-1977f713d003 */
using Proxy.Domain.Interfaces;
using Proxy.ProxyProtection;


IHotelPerson protectedProxy = HotelStaffProxyFactory.CreateProtectedProxy();

// Tentativa de acessar métodos Staff
Console.WriteLine("Hotel staff trying to access kitchen");
protectedProxy.AccessKitchen();

Console.WriteLine("\nHotel staff trying to access monitor room");
protectedProxy.AccessMonitorRoom();

Console.WriteLine("\nHotel staff trying to check in");
protectedProxy.ChekIn();

Console.WriteLine("\nHotel staff trying to check out");
protectedProxy.ChekOut();

Console.WriteLine("\nHotel staff trying to rate the hotel");
protectedProxy.Rate();


protectedProxy = HotelGuestProxyFactory.CreateProtectedProxy();

// Tentativa de acessar métodos Guest
Console.WriteLine("\n\nHotel staff trying to access kitchen");
protectedProxy.AccessKitchen();

Console.WriteLine("\nHotel staff trying to access monitor room");
protectedProxy.AccessMonitorRoom();

Console.WriteLine("\nHotel staff trying to check in");
protectedProxy.ChekIn();

Console.WriteLine("\nHotel staff trying to check out");
protectedProxy.ChekOut();

Console.WriteLine("\nHotel staff trying to rate the hotel");
protectedProxy.Rate();

