namespace AbstractFactoryGUI.Product
{
    public class WindowsButtom : IButtom
    {
        public void Paint()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Buttom in Windows O.S.");
            Console.ResetColor();
        }
    }
}
