namespace StateExample.State;
// Implementação dos estados
public class StateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Executando ação do Estado A.");
        context.State = new StateB();
    }
}