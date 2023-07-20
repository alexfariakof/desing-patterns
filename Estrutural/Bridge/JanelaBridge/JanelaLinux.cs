using JanelaBridge.Interface;

namespace JanelaBridge
{
    public class JanelaLinux : IJanelaBridge
    {
        public void PrintButtom(string title)
        {
            Console.WriteLine(title + " Botão Linux");
        }

        public void PrintJanela(string title)
        {
            Console.WriteLine(title + " Janela Linux");
        }
    }
}