namespace PrototypeVillain.Villains
{
    public class Scrull : Villain, IVillainPrototype
    {
        public Villain Clone()
        {
            return (Villain)this.MemberwiseClone();
        }

        public Villain DeepCopy()
        {
            var result = (Villain)this.MemberwiseClone();
            result.Power = new Power("Regeneração");
            return result;
        }

        public Villain ShallowCopy()
        {
            return (Villain)this.MemberwiseClone();
        }
    }
}