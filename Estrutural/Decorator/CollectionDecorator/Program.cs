// Interface base que representa uma coleção de números inteiros
public interface INumberCollection
{
    void Add(int number);
    void Print();
    List<int> GetNumbers();
}

// Implementação básica da coleção de números inteiros
public class NumberCollection : INumberCollection
{
    private List<int> numbers = new List<int>();

    public void Add(int number)
    {
        numbers.Add(number);
    }

    public void Print()
    {
        Console.WriteLine("Numbers in the collection:");
        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    public List<int> GetNumbers()
    {
        return numbers;
    }
}

// Decorador para adicionar funcionalidade de calcular a soma dos números na coleção
public class SumDecorator : INumberCollection
{
    private INumberCollection collection;

    public SumDecorator(INumberCollection collection)
    {
        this.collection = collection;
    }

    public void Add(int number)
    {
        collection.Add(number);
    }

    public void Print()
    {
        collection.Print();
        var numbers = collection.GetNumbers();
        var sum = numbers.Sum();
        Console.WriteLine($"Sum of numbers: {sum}");
    }

    public List<int> GetNumbers()
    {
        return collection.GetNumbers();
    }
}

public partial class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World! Collection Decorator");
        Console.WriteLine("");
        INumberCollection collection = new NumberCollection();
        collection.Add(10);
        collection.Add(20);
        collection.Add(30);

        Console.WriteLine("Original Collection:");
        collection.Print();

        // Usando o decorador para adicionar funcionalidade de cálculo da soma
        INumberCollection sumDecorator = new SumDecorator(collection);
        Console.WriteLine("\nCollection with Sum Decorator:");
        sumDecorator.Print();
    }
}

