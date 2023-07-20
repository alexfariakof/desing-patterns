using JanelaBridge.Interface;

namespace JanelaBridge
{
    public class JanelaDialog : JanelaAbstract
    {
        public JanelaDialog(IJanelaBridge _janela) : base(_janela)
        {
        }

        public override void Print()
        {
            PrintJanela("Atenção Deseja realizar a tarefa?");
            PrintButtom("SIM");
            PrintButtom("NÂO");
        }
    }
}
