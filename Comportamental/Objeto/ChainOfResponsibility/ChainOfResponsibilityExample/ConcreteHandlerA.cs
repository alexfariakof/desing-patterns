namespace ChainOfResponsibility;
public class ConcreteHandlerA : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 0 && request < 10)
            Console.WriteLine($"{ this.GetType().Name } handles request { request }");
        else if (sucessor != null)
            sucessor.HandleRequest(request);
    }
}