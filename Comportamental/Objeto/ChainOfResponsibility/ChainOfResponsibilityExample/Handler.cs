namespace ChainOfResponsibility;
public abstract class Handler
{
    protected Handler sucessor;
    public void SetSucessor(Handler sucessor)
    {
        this.sucessor = sucessor;
    }
    public abstract void HandleRequest(int request);
}