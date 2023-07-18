using AbstractFactoryGUI.Product;

namespace AbstractFactoryGUI.Factory
{
    public interface IGUIFactory
    {
        IButtom CreateButtom();
        ICheckBox CreateCheckBox();
    }
}