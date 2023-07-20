using DecoratorCar.Decorator.Base;

namespace DecoratorCar.Decorator.Concrete
{
    public class RodaLigaLeveDecorator : CarroDecorator
    {
        public RodaLigaLeveDecorator(ICarro _carro) : base(_carro)
        {
        }
        public override string ReturnCarro()
        {
            return base.ReturnCarro() + " com roda de liga leve";
        }
    }
}