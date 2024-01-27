using CommandExample.Interface;

namespace CommandExample;

/// <summary>
/// The Invoker class is responsible for executing commands.
/// </summary>
public class Invoker
{
    private ICommand _command;

    /// <summary>
    /// Sets the command to be executed.
    /// </summary>
    /// <param name="command">The command to be executed.</param>
    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    /// <summary>
    /// Executes the set command.
    /// </summary>
    public void ExecuteCommand()
    {
        _command.Execute();
    }
}