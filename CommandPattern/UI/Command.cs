namespace CommandPattern.UI
{
    /// <summary>
    /// The Command interface provides the ability to execute the command.
    /// </summary>
    public interface Command
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        public void Execute();
    }
}
