using AbstractFactoryGUI.Product;

namespace AbstractFactoryGUI.Factory
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
