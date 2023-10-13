using CommandPattern.Services;
using CommandPattern.UI;

namespace CommandPattern.Commands
{
    /// <summary>
    /// The CreateProjectCommand class is a Command that can be executed to create a project.
    /// </summary>
    public class CreateProjectCommand : Command
    {
        /// <summary>
        /// The ProjectService.
        /// </summary>
        private readonly ProjectService _projectService;

        /// <summary>
        /// The constructor sets the ProjectService.
        /// </summary>
        /// <param name="projectService">The ProjectService.</param>
        public CreateProjectCommand(ProjectService projectService)
        {
            _projectService = projectService;
        }

        /// <summary>
        /// Executes the command to create a project.
        /// </summary>
        public void Execute()
        {
            _projectService.CreateProject();
        }
    }
}
