using RestaurantIterator.Entity;
using RestaurantIterator.Interfaces;
using System.Collections;

namespace RestaurantIterator.Bakery
{
    public class BakeryMenuIterator : Iterator
    {
        ArrayList menuItems;
        int _currentIndex = 0;

        public BakeryMenuIterator(ArrayList _menuItems)
        {
             menuItems = _menuItems;
        }
        public bool HasNext()
        {
            return menuItems.Count -1 >= _currentIndex;
        }
        public object Next()
        {
            var menuItem = menuItems[_currentIndex];
            _currentIndex++;
            return menuItem;
        }
    }
}