using JanelaBridge.Interface;

namespace JanelaBridge
{
    public class JanelaWindows : IJanelaBridge
    {
        public void PrintButtom(string title)
        {
            Console.WriteLine(title + " Botão Windows");
        }

        public void PrintJanela(string title)
        {
            Console.WriteLine(title + " Janela Windows");
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine("Variação idependente da classe JanelaWindow" + i);
            }
        }
    }
}