using CommandExample.Interface;

namespace CommandExample.Commands;

/// <summary>
/// The SaveFileCommand class implements the ICommand interface and invokes the SaveFile method on the Receiver.
/// </summary>
public class SaveFileCommand : ICommand
{
    private Receiver _receiver;

    /// <summary>
    /// Initializes a new instance of the SaveFileCommand class.
    /// </summary>
    /// <param name="receiver">The Receiver instance.</param>
    public SaveFileCommand(Receiver receiver)
    {
        _receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
    }

    /// <summary>
    /// Executes the SaveFile command by invoking the SaveFile method on the Receiver.
    /// </summary>
    public void Execute()
    {
        _receiver.SaveFile();
    }
}