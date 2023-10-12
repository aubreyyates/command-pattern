using CommandPattern.Services;
using CommandPattern.UI;

namespace CommandPattern.Commands
{
    public class CreateProjectCommand : Command
    {
        private readonly ProjectService _customerService;

        public CreateProjectCommand(ProjectService customerService)
        {
            _customerService = customerService;
        }

        public void Execute()
        {
            _customerService.CreateProject();
        }
    }
}
