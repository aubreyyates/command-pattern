using CommandPattern.Services;
using CommandPattern.UI;

namespace CommandPattern.Commands
{
    public class AddCustomerCommand : Command
    {
        private readonly CustomerService _customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}
