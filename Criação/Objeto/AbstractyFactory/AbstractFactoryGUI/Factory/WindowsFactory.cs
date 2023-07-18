using AbstractFactoryGUI.Product;

namespace AbstractFactoryGUI.Factory
{
    public class WindowsFactory : IGUIFactory
    {
        public IButtom CreateButtom()
        {
            return new WindowsButtom();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
