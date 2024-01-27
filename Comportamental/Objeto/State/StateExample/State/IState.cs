namespace StateExample.State;
// Interface para os estados
public interface IState
{
    void Handle(Context context);
}