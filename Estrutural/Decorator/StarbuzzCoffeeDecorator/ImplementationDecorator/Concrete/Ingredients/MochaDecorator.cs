using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Ingredients.Base;
using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Interface;

namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete.Ingredients
{
    public class MochaDecorator : IngredientsDecorator
    {
        public MochaDecorator(IBeverage _beverage) : base(_beverage)  {  }
        public override string GetDescripition()
        {
            return base.GetDescripition() + " com chocolate";
        }
        public override decimal GetCost()
        {
            return base.GetCost() + new decimal(7.50);
        }
    }
}