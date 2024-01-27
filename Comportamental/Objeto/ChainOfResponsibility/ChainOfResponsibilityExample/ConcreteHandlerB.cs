namespace ChainOfResponsibility;
public class ConcreteHandlerB: Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10 && request < 20)
            Console.WriteLine($"{this.GetType().Name} handles request {request}");
        else if (sucessor != null)
            sucessor.HandleRequest(request);
    }
}