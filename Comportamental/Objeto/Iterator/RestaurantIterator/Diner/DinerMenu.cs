using RestaurantIterator.Entity;
using RestaurantIterator.Interfaces;

namespace RestaurantIterator.Diner
{
    public class DinerMenu
    {
        static readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Refeição Vegetariana", "Alfrace com Tomate ", true, new decimal(50.4));
            AddItem("Almoço", "Bife a parmegiana", false, new decimal(100));
            AddItem("Jantar", "Peixe Frito", false, new decimal(200.48));
        }

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
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
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Lista de items no menu cheia!");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }
        public MenuItem[]  GetMenuItems()
        {
            return menuItems;
        }
        public void RemoveItem(int index) 
        {
            menuItems[index] = null;
            numberOfItems--;
        }
    }
}