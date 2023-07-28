using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Ingredients.Base;
using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Interface;

namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete.Ingredients
{
    public class SoyDecorator : IngredientsDecorator
    {
        public SoyDecorator(IBeverage _beverage) : base(_beverage) { }
        public override string GetDescripition()
        {
            return base.GetDescripition() + " com soja";
        }
        public override decimal GetCost()
        {
            return base.GetCost() + new decimal(4.80);
        }
    }
}