using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete;
using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Concrete.Ingredients;
using desing_patterns.Estrutural.Decorator.StarbuzzCoffeeDecorator.Interface;
/*
  Este é um bom exemplo do princípio Open/Closed - As classes, módulos, etc devem ser abertas para extensão,
mas fechadas para modificação, o que significa que o comportamento de uma entidade pode ser estendido sem 
alterar seu código fonte.
  O objetivo é permitir que as classes sejam facilmente estendidas para incorporar um novo comportamento
sem modificar o código existente. Se a imelmentação estiver correta projetos que são resistentes a mudanças
e suficientemente flexíveis para assumir novos recursos para atender aos requisitos que mudam.
 */


Console.WriteLine("Hello, World! Starbuzz Coffee");
Console.WriteLine("");
IBeverage beverageDarkRoast = new DarkRoast();
beverageDarkRoast = new MilkDecorator(beverageDarkRoast);

Console.WriteLine($"Descrição : {beverageDarkRoast.GetDescripition()} - Preço : R$ {beverageDarkRoast.GetCost().ToString("N2")}.");
Console.WriteLine("");
IBeverage beverageExpress = new Express();
beverageExpress = new MochaDecorator(beverageExpress);
beverageExpress = new MochaDecorator(beverageExpress);

Console.WriteLine($"Descrição : {beverageExpress.GetDescripition()} - Preço : R$ {beverageExpress.GetCost().ToString("N2")}.");
Console.WriteLine("");

IBeverage beverageDecaf = new Decaf();
beverageDecaf = new SoyDecorator(beverageDecaf);
beverageDecaf = new WhipDecorator(beverageDecaf);
Console.WriteLine($"Descrição : {beverageDecaf.GetDescripition()} - Preço : R$ {beverageDecaf.GetCost().ToString("N2")}.");
Console.WriteLine("");

IBeverage beverageHouseBlend = new HouseBlend();
Console.WriteLine($"Descrição : {beverageHouseBlend.GetDescripition()} - Preço : R$ {beverageHouseBlend.GetCost().ToString("N2")}.");
Console.WriteLine("");

IBeverage beverageWater = new Water();
Console.WriteLine($"Descrição : {beverageWater.GetDescripition()} - Preço : R$ {beverageWater.GetCost().ToString("N2")}.");
Console.WriteLine("");

IBeverage beverageTea = new Tea();
Console.WriteLine($"Descrição : {beverageTea.GetDescripition()} - Preço : R$ {beverageTea.GetCost().ToString("N2")}.");
Console.ReadKey();