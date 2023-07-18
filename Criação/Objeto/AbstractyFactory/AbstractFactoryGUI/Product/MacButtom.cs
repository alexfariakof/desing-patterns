namespace AbstractFactoryGUI.Product
{
    public class MacButtom : IButtom
    {
        public void Paint()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Buttom in Mac O.S.");
            Console.ResetColor();
        }
    }
}
