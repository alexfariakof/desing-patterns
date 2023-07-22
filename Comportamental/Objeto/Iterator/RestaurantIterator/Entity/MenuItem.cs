namespace RestaurantIterator.Entity
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Vegetarian { get; set; }
        public decimal? Price { get; set; }
    }
}