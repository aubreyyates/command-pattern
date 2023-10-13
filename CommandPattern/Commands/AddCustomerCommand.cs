using CommandPattern.Services;
using CommandPattern.UI;

namespace CommandPattern.Commands
{
    /// <summary>
    /// The AddCustomerCommand class is a Command that can be executed to add a customer.
    /// </summary>
    public class AddCustomerCommand : Command
    {
        /// <summary>
        /// The CustomerService.
        /// </summary>
        private readonly CustomerService _customerService;

        /// <summary>
        /// The constructor sets the CustomerService.
        /// </summary>
        /// <param name="projectService">The CustomerService.</param>
        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Executes the command to add a customer.
        /// </summary>
        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}
