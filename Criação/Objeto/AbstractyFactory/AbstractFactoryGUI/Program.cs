
using AbstractFactoryGUI.Factory;
using desing_patterns.Criação.Objeto.AbstractFactoryGUI.Factory;
using desing_patterns.Criação.Objeto.AbstractyFactory.AbstractFactoryGUI.Factory;

IGUIFactory factory;

factory = new WindowsFactory();
factory.CreateButtom().Paint();
factory.CreateCheckBox().Paint();

factory = new MacFactory();
factory.CreateButtom().Paint();
factory.CreateCheckBox().Paint();
