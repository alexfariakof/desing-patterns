namespace MementoExample.Memento;
public class EditorTexto : IOriginator
{
    private string texto;

    public EditorTexto(string texto)
    {
        this.texto = texto;
    }

    public void Escrever(string novoTexto)
    {
        Console.WriteLine("Escrevendo: " + novoTexto);
        texto += " " + novoTexto;
    }

    public ConcreteMemento Salvar()
    {
        Console.WriteLine("Salvando estado. Texto atual: " + texto);
        return new ConcreteMemento(texto);
    }

    public void Restaurar(ConcreteMemento memento)
    {
        texto = memento.GetText();
        Console.WriteLine("Estado restaurado. Texto atual: " + texto);
    }

    public void ExibirTexto()
    {
        Console.WriteLine("Texto atual: " + texto);
    }
}
