namespace ObserverExample.Observer;
// Define a classe concreta do assunto
public class ConcreteSubject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(int value)
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(value);
        }
    }
}