namespace DecoratorCar
{
    //ConcreteComponent
    public sealed class Carro : ICarro
    {
        public string ReturnCarro()
        {
            var carro = "Este é um carro básico: ";
            return carro;
        }
    }
}