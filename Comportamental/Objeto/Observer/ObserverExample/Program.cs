
/*
Neste exemplo, temos uma classe ConcreteSubject que implementa a interface ISubject e mantém uma lista de observadores 
que implementam a interface IObserver. A classe ConcreteObserver implementa a interface IObserver e 
recebe as atualizações do assunto através do método Update.

Ao executar este código, a saída seria:

Observer Observer 1 received update: 42
Observer Observer 2 received update: 42
Observer Observer 1 received update: 84

Observe que o primeiro valor enviado é 42, e ambos os observadores o recebem. 
Em seguida, um dos observadores é removido da lista de observadores e um novo valor (84) é enviado, sendo que apenas o observador restante o recebe.
*/
using ObserverExample.Observer;

Console.WriteLine("Hello, Observer!\n");
ConcreteSubject subject = new ConcreteSubject();
ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

subject.RegisterObserver(observer1);
subject.RegisterObserver(observer2);

subject.NotifyObservers(42);

subject.RemoveObserver(observer2);

subject.NotifyObservers(84);

Console.ReadLine();



