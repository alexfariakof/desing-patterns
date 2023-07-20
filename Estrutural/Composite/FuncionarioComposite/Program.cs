
using FuncionarioComposite.Composite;

FuncionarioCompositeImpl tree = new("Izaide");
FuncionarioLeaf folha1 = new("Alex");
FuncionarioCompositeImpl folha2 = new("Mariza");
FuncionarioLeaf folha3 = new("Pedro");

tree.Add(folha1);
tree.Add(folha2);
tree.Add(folha3);


FuncionarioLeaf folha4 = new("Lara");
FuncionarioLeaf folha5 = new("Leandro");
folha2.Add(folha4);
folha2.Add(folha5);

Console.WriteLine(tree.Operation());
Console.WriteLine(folha2.Operation());