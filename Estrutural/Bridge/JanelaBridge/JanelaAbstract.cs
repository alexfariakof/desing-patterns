using JanelaBridge.Interface;

namespace JanelaBridge
{
    public abstract class JanelaAbstract
    {
        protected IJanelaBridge janela;

        public JanelaAbstract(IJanelaBridge _janela)
        {
            janela = _janela;
        }

        public void PrintButtom(string title)
        {            
            janela.PrintButtom(title);
        }

        public void PrintJanela(string title)
        {
            Console.WriteLine("Desenhando Janela!!!!");
            janela.PrintJanela(title);
        }

        public abstract void Print();
    }
}