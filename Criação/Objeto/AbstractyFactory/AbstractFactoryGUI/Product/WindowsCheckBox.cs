namespace desing_patterns.Criação.Objeto.AbstractyFactory.AbstractFactoryGUI.Product
{
    public class WindowsCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("CheckBox in Windows O.S.");
            Console.ResetColor();
        }
    }
}
