namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete
{
    public class DarkRoast : Beverage
    {
        public DarkRoast() : base() { }
        public override string GetDescripition()
        {
            return base.GetDescripition() + " Café DarkRoast";
        }
        public override decimal GetCost()
        {
            return new decimal(2.50);
        }
    }
}