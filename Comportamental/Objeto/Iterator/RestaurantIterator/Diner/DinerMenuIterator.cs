using RestaurantIterator.Entity;
using RestaurantIterator.Interfaces;

namespace RestaurantIterator.Diner
{
    public class DinerMenuIterator : Iterator        
    {
        private MenuItem[] items;
        private int position = 0;
        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }
        public bool HasNext()
        {
            if (position > items.Length || items[position] == null) 
            { 
                return false;
            }
            else
            {
                return true;
            }
        }
        public object Next()
        {
            MenuItem item = items[position];
            position++;
            return item;
        }
    }
}