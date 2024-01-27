namespace ObserverExample.Observer;
// Define a interface do assunto
public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(int value);
}