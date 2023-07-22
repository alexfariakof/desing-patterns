using RestaurantIterator.Entity;
using RestaurantIterator.Interfaces;
using System.Collections;

namespace RestaurantIterator.Bakery
{
    public class BakeryMenu
    {
        ArrayList menuItems;
        public BakeryMenu()
        {
            menuItems = new ArrayList();
            AddItem("K&B Café da manhã", "Pão com Manteiga", false, new decimal(2.6));
            AddItem("K&B Café da manhã", "Pão com ovo", false, new decimal(5.8));
            AddItem("K&B Café da manhã", "Pão torrado", false, new decimal(1.5));
        }
        public Iterator CreateIterator()
        {
            return new BakeryMenuIterator(menuItems);
        }
        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            MenuItem menuItem = new MenuItem 
            {
                Name = name,
                Description = description,
                Vegetarian = vegetarian,
                Price = price
            };
            menuItems.Add(menuItem);
        }

        public ArrayList GetMenuItems()
        {
            return menuItems;
        }
        public void RemoveItem(int index)
        {
            menuItems.RemoveAt(index);
        }
    }
}