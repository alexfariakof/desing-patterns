namespace MementoExample.Memento;
// Classe Caretaker
public class CaretakerMemento
{
    private List<ConcreteMemento> estadosSalvos = new();

    public void AdicionarMemento(ConcreteMemento memento)
    {
        estadosSalvos.Add(memento);
    }

    public ConcreteMemento GetMemento(int indice)
    {
        return estadosSalvos[indice];
    }
}