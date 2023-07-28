namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete
{
    public class Tea : Beverage
    {
        public Tea() : base() { }
        public override string GetDescripition()
        {
            return base.GetDescripition() + " Chá";
        }
        public override decimal GetCost()
        {
            return new decimal(8.55);
        }
    }
}