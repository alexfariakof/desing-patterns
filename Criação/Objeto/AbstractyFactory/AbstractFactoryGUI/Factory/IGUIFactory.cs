using desing_patterns.Criação.Objeto.AbstractyFactory.AbstractFactoryGUI.Product;

namespace desing_patterns.Criação.Objeto.AbstractyFactory.AbstractFactoryGUI.Factory
{
    public interface IGUIFactory
    {
        IButtom CreateButtom();
        ICheckBox CreateCheckBox();
    }
}