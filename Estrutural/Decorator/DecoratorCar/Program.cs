
using DecoratorCar;
using DecoratorCar.Decorator.Concrete;
/*
    Dinamicamente, agregar responsabilidades adicionais a objetos.
 Os decorators fornecem uma alternativa flexível ao uso de 
subclasses para extensão de funcionalidades.


 */
ICarro carro = new Carro();
ICarro arCondicionado = new ArCondicionadoDecorator(carro);
ICarro bancoCouro = new BancoCouroDecorator(arCondicionado);
ICarro kitGas = new KitGasDecorator(bancoCouro);
ICarro rodaLigaLeve = new RodaLigaLeveDecorator(kitGas);


Console.WriteLine(rodaLigaLeve.ReturnCarro());

