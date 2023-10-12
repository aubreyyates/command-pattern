namespace CommandPattern.UI
{
    public class Button
    {
        private string Label;
        private readonly Command _command;

        public Button(Command command)
        {
            _command = command;
        }
        public void Click() 
        {
            _command.Execute();
        }
    }
}
