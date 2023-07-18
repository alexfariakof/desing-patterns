
using BuilderHamburger.Builer;

HamburguerBuilder hamburguerBuilder = new();

var xSalada  = hamburguerBuilder
    .SetTipoPao("Australiano")
    .SetTipoCarne("Normal")
    .TemSalada().Build();

Console.WriteLine(xSalada.GetDescricao());

hamburguerBuilder = new();
var xBacon = hamburguerBuilder
        .SetTipoPao("Pimenta")
        .SetTipoCarne("Frando")
        .TemQueijo()
        .TemBacon()
        .Build();

Console.WriteLine(xBacon.GetDescricao());

hamburguerBuilder = new();
var xTudo = hamburguerBuilder
        .SetTipoPao("Normal")
        .SetTipoCarne("Duas Bovina")
        .TemQueijo()
        .TemBacon()
        .TemBatataPalha()
        .TemSalada()
        .Build();
Console.WriteLine(xTudo.GetDescricao());
