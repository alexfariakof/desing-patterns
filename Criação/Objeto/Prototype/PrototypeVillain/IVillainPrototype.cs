namespace PrototypeVillain
{
    public interface IVillainPrototype
    {
        Villain Clone();
        Villain DeepCopy();
        Villain ShallowCopy();
    }
}