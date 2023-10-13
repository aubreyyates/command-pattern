namespace CommandPattern.UI
{
    /// <summary>
    /// The Button class represents a button the user interface.
    /// </summary>
    public class Button
    {
        /// <summary>
        /// The button label.
        /// </summary>
        private string Label;

        /// <summary>
        /// The Command available to the button.
        /// </summary>
        private readonly Command _command;

        /// <summary>
        /// The constructor sets the Command.
        /// </summary>
        /// <param name="command">The Command.</param>
        public Button(Command command)
        {
            _command = command;
        }

        /// <summary>
        /// Handles the click event.
        /// </summary>
        public void Click() 
        {
            _command.Execute();
        }
    }
}
