using DecoratorCar.Decorator.Base;

namespace DecoratorCar.Decorator.Concrete
{
    public class ArCondicionadoDecorator : CarroDecorator
    {
        public ArCondicionadoDecorator(ICarro _carro) : base(_carro)
        {
        }
        public override string ReturnCarro()
        {
            return base.ReturnCarro() + " com Ar condicionado";
        }
    }
}