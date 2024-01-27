using CommandExample.Interface;

namespace CommandExample.Commands;

/// <summary>
/// The OpenFileCommand class implements the ICommand interface and invokes the OpenFile method on the Receiver.
/// </summary>
public class OpenFileCommand : ICommand
{
    private Receiver _receiver;

    /// <summary>
    /// Initializes a new instance of the OpenFileCommand class.
    /// </summary>
    /// <param name="receiver">The Receiver instance.</param>
    public OpenFileCommand(Receiver receiver)
    {
        _receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
    }

    /// <summary>
    /// Executes the OpenFile command by invoking the OpenFile method on the Receiver.
    /// </summary>
    public void Execute()
    {
        _receiver.OpenFile();
    }
}