using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Interface;

namespace desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Ingredients.Base
{
    public abstract class IngredientsDecorator : IBeverage
    {
        private readonly IBeverage beverage;
        public IngredientsDecorator(IBeverage _beverage)
        {            
            beverage =_beverage;
        }
        public virtual string GetDescripition()
        {
            return beverage.GetDescripition();
        }
        public virtual decimal GetCost()
        {
            return beverage.GetCost();
        }
    }
}