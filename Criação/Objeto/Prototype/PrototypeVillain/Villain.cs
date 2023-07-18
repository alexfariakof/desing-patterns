namespace PrototypeVillain
{
    public abstract class Villain
    {
        public string? Name { get; set; }
        public Power? Power { get; set; }
        public int TemporaryRealityNumber { get; set; }

        public void PrintDescricao()
        {
            Console.WriteLine($"Vilão {this.GetType().Name}: {Name} com Poder: {Power?.Name} da realidade {TemporaryRealityNumber} ");
        }
    }
}