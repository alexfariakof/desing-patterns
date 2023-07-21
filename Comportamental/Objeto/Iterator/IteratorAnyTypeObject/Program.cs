using IteratorAnyTypeObject.Concrete;
using IteratorAnyTypeObject.Interface;
using System.Collections;

ConcreteAggregate aggregate = new ConcreteAggregate();

aggregate.AddItem("Item 1 ");
aggregate.AddItem(() => new List<int> { 1, 2 });
aggregate.AddItem(new ArrayList());
aggregate.AddItem(new object());
ICollection<float> list = new List<float>{ 0, 0 };
aggregate.AddItem(list);
aggregate.AddItem("Item 4 ");
aggregate.AddItem(1);


IIterator iterator = aggregate.CreateIterator();
Console.WriteLine("Interando sobre a coleção");
for(object item = iterator.First(); item != iterator.Last();  item = iterator.Next())
{
    Console.WriteLine(item.GetType().Name);
}
Console.WriteLine(iterator.CurrentItem);
Console.ReadKey();