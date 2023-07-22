using RestaurantIterator.Bakery;
using RestaurantIterator.CoffeeShop;
using RestaurantIterator.Diner;
using RestaurantIterator.Entity;
using RestaurantIterator.Interfaces;

namespace RestaurantIterator
{
    public class Waiter
    {
        BakeryMenu bakeryMenu;
        DinerMenu dinerMenu;
        CoffeeShopMenu coffeeShopMenu;
        public Waiter(BakeryMenu _bakeryMenu, DinerMenu _dinerMenu, CoffeeShopMenu _coffeeShop)
        {
            this.bakeryMenu = _bakeryMenu;
            this.dinerMenu = _dinerMenu;
            this.coffeeShopMenu = _coffeeShop;
        }
        public void PrintMenu()
        {
            Iterator bakeryItaretor = bakeryMenu.CreateIterator();
            Iterator dinerIterator = dinerMenu.CreateIterator();
            Iterator cofferShoppeIterator = coffeeShopMenu.CreateIterator();
            Console.WriteLine("Café da Manhã : ");
            PrintMenu(bakeryItaretor);
            Console.WriteLine("");
            PrintMenu(dinerIterator);
            Console.WriteLine("");
            PrintMenu(cofferShoppeIterator);
        }
        private void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($" Name: {menuItem.Name}, Preço: {menuItem.Price}, Descrição: {menuItem.Description} ");
            }
        }
    }
}