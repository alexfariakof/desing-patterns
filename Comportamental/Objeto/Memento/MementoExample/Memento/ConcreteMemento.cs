namespace MementoExample.Memento;
public class ConcreteMemento : IMemento
{
    private readonly string texto;

    public ConcreteMemento(string texto)
    {
        this.texto = texto;
    }

    public string GetText()
    {
        return texto;
    }
}