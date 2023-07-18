using desing_patterns.create.FactoryMethod.Creator;
using desing_patterns.create.FactoryMethod.Product;

internal class Program
{
    private static void Main(string[] args)
    {
        Tela Tela1 = new ConcreteTelaWeb().CriarTela();
        Tela Tela2 = new ConcreteTelaSmartPhone().CriarTela();
        Tela Tela3 = new ConcreteTelaSmartWatch().CriarTela();
        Tela Tela4 = new ConcreteTelaSmartTV().CriarTela();

        Console.ForegroundColor = Tela1.ForegroundColor;
        Console.WriteLine("Tela Web => " + Tela1.GetMessage());
        Console.ForegroundColor = Tela2.ForegroundColor;
        Console.WriteLine("Tela Smart Phone => " + Tela2.GetMessage());
        Console.ForegroundColor = Tela3.ForegroundColor;
        Console.WriteLine("Tela Smart Watch => " + Tela3.GetMessage());
        Console.ForegroundColor = Tela4.ForegroundColor;
        Console.WriteLine("Tela Smart TV => " + Tela4.GetMessage());
        Console.ResetColor();
    }
}