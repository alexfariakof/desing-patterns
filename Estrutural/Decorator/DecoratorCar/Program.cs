
using DecoratorCar;
using DecoratorCar.Decorator.Concrete;

ICarro carro = new Carro();
ICarro arCondicionado = new ArCondicionadoDecorator(carro);
ICarro bancoCouro = new BancoCouroDecorator(arCondicionado);
ICarro kitGas = new KitGasDecorator(bancoCouro);
ICarro rodaLigaLeve = new RodaLigaLeveDecorator(kitGas);


Console.WriteLine(rodaLigaLeve.ReturnCarro());

