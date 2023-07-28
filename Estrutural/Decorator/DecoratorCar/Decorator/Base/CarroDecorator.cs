namespace DecoratorCar.Decorator.Base
{
    //Decorator Base
    public abstract class CarroDecorator : ICarro
    {
        private readonly ICarro Carro;
        public CarroDecorator(ICarro _carro)
        {
            Carro = _carro;
        }
        public  virtual string ReturnCarro()
        {
            return Carro.ReturnCarro();
        }
    }
}