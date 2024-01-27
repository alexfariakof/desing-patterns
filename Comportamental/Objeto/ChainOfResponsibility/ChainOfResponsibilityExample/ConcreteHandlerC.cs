namespace ChainOfResponsibility;
public class ConcreteHandlerC : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20 && request < 100)
            Console.WriteLine($"{this.GetType().Name} handles request {request}");
        else if (sucessor != null)
            sucessor.HandleRequest(request);

    }
}