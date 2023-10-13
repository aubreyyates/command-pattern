using CommandPattern.Services;
using CommandPattern.UI;

namespace CommandPattern.Commands
{
    public class CreateProjectCommand : Command
    {
        private readonly ProjectService _projectService;

        public CreateProjectCommand(ProjectService projectService)
        {
            _projectService = projectService;
        }

        public void Execute()
        {
            _projectService.CreateProject();
        }
    }
}
