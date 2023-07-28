namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete
{
    public class Water : Beverage
    {
        public Water() : base() {  }
        public override string GetDescripition()
        {
            return base.GetDescripition() + " Aguá";
        }
        public override decimal GetCost()
        {
            return new decimal(4.23);
        }
    }
}