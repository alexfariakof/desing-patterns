using MementoExample.Memento;

Console.WriteLine("Hello, Memento!\n");


EditorTexto editor = new("Hello world!");
CaretakerMemento gerenciador = new();

editor.ExibirTexto();

gerenciador.AdicionarMemento(editor.Salvar());

editor.Escrever("Olá");
editor.ExibirTexto();
Console.WriteLine("\n");

gerenciador.AdicionarMemento(editor.Salvar());

editor.Escrever("Mundo");
editor.ExibirTexto();
Console.WriteLine("\n");

gerenciador.AdicionarMemento(editor.Salvar());

editor.Restaurar(gerenciador.GetMemento(1));
editor.ExibirTexto();
Console.WriteLine("\n");

editor.Restaurar(gerenciador.GetMemento(0));
editor.ExibirTexto();
Console.WriteLine("\n");


Console.ReadKey();