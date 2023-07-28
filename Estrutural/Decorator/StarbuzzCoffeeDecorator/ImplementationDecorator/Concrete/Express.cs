namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete
{
    public class Express : Beverage
    {
        public Express() : base() { }
        public override string GetDescripition()
        {
            return base.GetDescripition() + " Café Expresso";
        }
        public override decimal GetCost()
        {
            return new decimal(4.50);
        }
    }
}