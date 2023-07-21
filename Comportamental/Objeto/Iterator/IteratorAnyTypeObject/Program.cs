using IteratorAnyTypeObject.Concrete;
using IteratorAnyTypeObject.Interface;
using System.Collections;

ConcreteAggregate aggregate = new ConcreteAggregate();

aggregate.AddItem("Item 1 ");
aggregate.AddItem(() => new List<int> { 1, 2 });
aggregate.AddItem(new ArrayList());
aggregate.AddItem(new Array[10]);
aggregate.AddItem(new());
ICollection<float> list = new List<float>{ 0, 0 };
aggregate.AddItem(list);
aggregate.AddItem(new Hashtable());
aggregate.AddItem(new Dictionary<string, int>());
aggregate.AddItem(2.8);
aggregate.AddItem(8);
aggregate.AddItem(new byte());
aggregate.AddItem(1);


IIterator iterator = aggregate.CreateIterator();
Console.WriteLine("Interando sobre a coleção");
for(object item = iterator.First(); item != iterator.Last();  item = iterator.Next())
{
    Console.WriteLine(item.GetType().Name);
}
Console.WriteLine(iterator.CurrentItem);
Console.ReadKey();

/*
 * Este Padrão permite acessar sequencialmente os elementos 
 * de um objeto agregado sem expor a sua representação subjacente ou sua implementação 
 */