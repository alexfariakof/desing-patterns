//Define as operações para iterar sobre a coleção 
namespace IteratorAnyTypeObject.Interface
{
    public interface IIterator
    {
        object First();
        object Last();
        object Next();
        object CurrentItem { get; }
        bool IsDone { get; }
    }
}