using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Interface;

namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator
{
    public abstract class Beverage : IBeverage
    {
        private string description = "Bebida Starbuzz";
        public abstract decimal GetCost();
        public virtual string GetDescripition()
        {
            return description;
        }
    }
}