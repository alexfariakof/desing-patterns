using CommandExample;
using CommandExample.Commands;

Console.WriteLine("Hello, Commmand!\n");


Receiver receiver = new Receiver();
CloseFileCommand closeFileCommand = new(receiver);
OpenFileCommand openFileCommand = new(receiver);
SaveFileCommand saveFileCommand = new(receiver);

Invoker invoker = new();
invoker.SetCommand(closeFileCommand);
invoker.ExecuteCommand();

invoker.SetCommand(openFileCommand);
invoker.ExecuteCommand();

invoker.SetCommand(saveFileCommand);
invoker.ExecuteCommand();
