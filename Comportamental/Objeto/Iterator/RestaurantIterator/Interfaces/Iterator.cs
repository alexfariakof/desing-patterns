namespace RestaurantIterator.Interfaces
{
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }
}