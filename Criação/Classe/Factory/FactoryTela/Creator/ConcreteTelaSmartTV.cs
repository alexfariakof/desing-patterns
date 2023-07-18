using desing_patterns.create.FactoryMethod.Product;

namespace desing_patterns.create.FactoryMethod.Creator
{
    public class ConcreteTelaSmartTV : TelaCreator
    {
        public override Tela CriarTela()
        {
            return new TelaSmartTV();
        }        
    }
}