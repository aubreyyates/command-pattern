using CommandPattern.UI;

namespace CommandPattern
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
