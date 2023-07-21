using IteratorAnyTypeObject.Interface;
//Implementa a inetrface IIterator e mantém o controle do estado da iteração.
namespace IteratorAnyTypeObject.Concrete
{
    public class ConcreteItarator : IIterator
    {
        private ConcreteAggregate concreteAggregate;
        private int currentIndex = 0;
        public ConcreteItarator(ConcreteAggregate _concreteAggregate)
        {
            concreteAggregate = _concreteAggregate;

        }
        public object CurrentItem => concreteAggregate[currentIndex];
        public bool IsDone => currentIndex >= concreteAggregate.Count -1;
        public object First()
        {
            return this.concreteAggregate[0];
        }
        public object Last()
        {
            return concreteAggregate[concreteAggregate.Count -1];
        }
        public object Next()
        {
            object next = null;
            if (currentIndex < concreteAggregate.Count - 1)
            {
                currentIndex++;
                next = concreteAggregate[currentIndex];
            }

            return concreteAggregate[this.currentIndex];
        }
    }
}