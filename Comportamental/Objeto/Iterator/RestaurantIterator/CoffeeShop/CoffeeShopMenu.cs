using RestaurantIterator.Entity;
using RestaurantIterator.Interfaces;
using System.Collections;

namespace RestaurantIterator.CoffeeShop
{
    public class CoffeeShopMenu
    {
        Hashtable menuItems;
        public CoffeeShopMenu()
        {
            menuItems = new Hashtable(); ;
            AddItem("Café", "Café normal", false, new decimal(10.4));
            AddItem("Café com Leite", "Café com leíte ", false, new decimal(5));
            AddItem("Café Expreso", "Café Expresso", false, new decimal(2.47));

        }
        public Iterator CreateIterator()
        {
            return new CoffeeShopMenuIterator(menuItems);
        }
        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            MenuItem menuItem = new MenuItem
            {
                Name = name,
                Description = description,
                Vegetarian = vegetarian,
                Price = price,
            };
            menuItems.Add(menuItem.Name, menuItem);
        }

        public Hashtable  MenuItems()
        {
            return menuItems;
        }
        public void RemoveItem(object key)
        {
            menuItems.Remove(key);
        }
    }
}
