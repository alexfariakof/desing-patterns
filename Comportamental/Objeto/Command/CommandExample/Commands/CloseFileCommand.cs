using CommandExample.Interface;

namespace CommandExample.Commands
{
    /// <summary>
    /// The CloseFileCommand class implements the ICommand interface and invokes the CloseFile method on the Receiver.
    /// </summary>
    public class CloseFileCommand : ICommand
    {
        private Receiver _receiver;

        /// <summary>
        /// Initializes a new instance of the CloseFileCommand class.
        /// </summary>
        /// <param name="receiver">The Receiver instance.</param>
        public CloseFileCommand(Receiver receiver)
        {
            _receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
        }

        /// <summary>
        /// Executes the CloseFile command by invoking the CloseFile method on the Receiver.
        /// </summary>
        public void Execute()
        {
            _receiver.CloseFile();
        }
    }
}
