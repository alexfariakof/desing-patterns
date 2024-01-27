namespace StateExample.State;
public class StateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Executando ação do Estado B.");
        context.State = new StateA();
    }
}