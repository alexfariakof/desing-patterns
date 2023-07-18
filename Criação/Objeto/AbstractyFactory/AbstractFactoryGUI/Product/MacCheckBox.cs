namespace AbstractFactoryGUI.Product
{
    public class MacCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("CheckBox in Mac O.S.");
            Console.ResetColor();
        }
    }
}
