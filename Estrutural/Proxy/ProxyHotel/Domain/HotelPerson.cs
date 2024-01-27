using Proxy.Domain.Interfaces;

namespace Proxy.Domain;
public class HotelPerson : IHotelPerson
{
    public HotelPerson() { }
    public void AccessKitchen()
    {
        Console.WriteLine("Accessing the kitchen");
    }
    public void AccessMonitorRoom()
    {
        Console.WriteLine("Accessing the monitor room");
    }
    public void ChekIn()
    {
        Console.WriteLine("Checking in");
    }
    public void ChekOut()
    {
        Console.WriteLine("Checking out");
    }
    public void Rate()
    {
        Console.WriteLine("Rate");
    }
}