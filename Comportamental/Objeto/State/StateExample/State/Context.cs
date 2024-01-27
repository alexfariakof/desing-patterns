namespace StateExample.State;
// Classe do contexto
public class Context
{
    private IState _state;

    public IState State
    {
        get { return _state; }
        set { _state = value; }
    }

    public void Request()
    {
        _state.Handle(this);
    }
}