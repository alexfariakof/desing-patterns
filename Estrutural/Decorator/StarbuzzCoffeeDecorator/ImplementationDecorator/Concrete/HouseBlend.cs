namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() : base() { }
        public override string GetDescripition()
        {
            return base.GetDescripition() + " Café House Blend";
        }
        public override decimal GetCost()
        {
            return new decimal(9.60);
        }
    }
}