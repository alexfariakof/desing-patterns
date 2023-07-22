using RestaurantIterator.Interfaces;
using System.Collections;

namespace RestaurantIterator.CoffeeShop
{
    public class CoffeeShopMenuIterator : Iterator
    {
        private Hashtable menuItems;
        private IEnumerator enumerator; 
        public CoffeeShopMenuIterator(Hashtable _menuItems)
        {
            this.menuItems = _menuItems;
            this.enumerator = menuItems.GetEnumerator();
        }
        public bool HasNext()
        {
            return enumerator.MoveNext(); 
        }
        public object Next()
        {            
            DictionaryEntry dictionaryEntry = (DictionaryEntry)enumerator.Current;
            var menuItem = dictionaryEntry.Value;
            return menuItem;
        }
    }
}