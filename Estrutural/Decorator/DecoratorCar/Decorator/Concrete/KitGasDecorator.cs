using DecoratorCar.Decorator.Base;

namespace DecoratorCar.Decorator.Concrete
{
    public class KitGasDecorator : CarroDecorator
    {
        public KitGasDecorator(ICarro _carro) : base(_carro)
        {
        }
        public override string ReturnCarro()
        {
            return base.ReturnCarro() + " com Kit gás";
        }
    }
}