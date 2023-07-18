
using AbstractFactoryGUI.Factory;

IGUIFactory factory;

factory = new WindowsFactory();
factory.CreateButtom().Paint();
factory.CreateCheckBox().Paint();

factory = new MacFactory();
factory.CreateButtom().Paint();
factory.CreateCheckBox().Paint();
