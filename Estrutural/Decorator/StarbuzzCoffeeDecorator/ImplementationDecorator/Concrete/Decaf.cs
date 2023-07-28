namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete
{
    public class Decaf : Beverage
    {
        public Decaf() : base()
        {
        }
        public override string GetDescripition()
        {
            return base.GetDescripition() + " Café Descafeinado";
        }
        public override decimal GetCost()
        {
            return new decimal(6.40);
        }
    }
}