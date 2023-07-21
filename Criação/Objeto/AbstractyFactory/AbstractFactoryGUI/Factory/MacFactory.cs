using AbstractFactoryGUI.Product;
using desing_patterns.Criação.Objeto.AbstractFactoryGUI.Product;
using desing_patterns.Criação.Objeto.AbstractyFactory.AbstractFactoryGUI.Product;

namespace desing_patterns.Criação.Objeto.AbstractyFactory.AbstractFactoryGUI.Factory
{
    public class MacFactory : IGUIFactory
    {
        public IButtom CreateButtom()
        {
            return new MacButtom();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }
}
