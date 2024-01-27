namespace ObserverExample.Observer;
// Define a classe concreta do observador
public class ConcreteObserver : IObserver
{
    private string _observerName;

    public ConcreteObserver(string name)
    {
        _observerName = name;
    }

    public void Update(int value)
    {
        Console.WriteLine($"Observer {_observerName} received update: {value}");
    }
}