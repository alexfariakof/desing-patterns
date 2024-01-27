using ChainOfResponsibility;

Console.WriteLine("Hello, Chain Of Responsibility Example!\n");

Handler handlerA= new ConcreteHandlerA();
Handler handlerB = new ConcreteHandlerB();
Handler handlerC = new ConcreteHandlerC();
handlerA.SetSucessor(handlerB);
handlerB.SetSucessor(handlerC);

// Inveia Requisições para o Chain 

int[] requests = { 2, 5, 14, 22, 18, 3, 27, 3, 78, 11, 25, 8 };

foreach (int request in requests)
{
    handlerA.HandleRequest(request);
}