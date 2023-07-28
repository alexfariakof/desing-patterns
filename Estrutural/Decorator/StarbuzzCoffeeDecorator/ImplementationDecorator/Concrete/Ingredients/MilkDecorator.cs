using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Ingredients.Base;
using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Interface;

namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete.Ingredients
{
    public class MilkDecorator : IngredientsDecorator
    {
        public MilkDecorator(IBeverage _beverage) : base(_beverage) { }
        public override string GetDescripition()
        {
            return base.GetDescripition() + " com leite";
        }
        public override decimal GetCost()
        {
            return base.GetCost() + new decimal(1.00);
        }
    }
}