using IteratorAnyTypeObject.Interface;
using System.Collections;
// Implementa a interface Aggregate e define a coelção a ser iterada
namespace IteratorAnyTypeObject.Concrete
{
    public class ConcreteAggregate : IAggregate
    {
        private ArrayList items = new ArrayList();
        public void AddItem(object _item)
        {
            items.Add(_item);
        }
        public IIterator CreateIterator()
        {
            return new ConcreteItarator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index] 
        { 
            get => items[index]; 
            set => items.Insert(index, value);
        }
    }
}