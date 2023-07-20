using DecoratorCar.Decorator.Base;

namespace DecoratorCar.Decorator.Concrete
{
    public class BancoCouroDecorator : CarroDecorator
    {
        public BancoCouroDecorator(ICarro _carro) : base(_carro)
        {
        }
        public override string ReturnCarro()
        {
            return base.ReturnCarro() + " com banco de couro";
        }
    }
}