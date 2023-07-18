namespace PrototypeVillain.Villains
{
    public class Kang : Villain, IVillainPrototype
    {
        public Villain Clone()
        {
            return (Villain)this.MemberwiseClone();
        }

        public Villain DeepCopy()
        {
            var result = (Villain)this.MemberwiseClone();
            result.Power = new Power("Teletransporte");
            return result;
        }

        public Villain ShallowCopy()
        {
            return (Villain)this.MemberwiseClone();
        }
    }
}