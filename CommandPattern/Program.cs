using CommandPattern.Commands;
using CommandPattern.Services;
using CommandPattern.UI;

// Create buttons that can use commands to execute something. These buttons come from a UI framework that doesn't
// know what will be executed when the buttons are clicked. Each button can use a different command to execute
// different things. It is up to the user of the UI framework to create these commands.

// Create a button that will add a customer when clicked.
var customerService = new CustomerService();
var addCustomerCommand = new AddCustomerCommand(customerService);
var buttonOne = new Button(addCustomerCommand);

// Prints "Customer Added".
buttonOne.Click();

// Create a button that will create a project when clicked.
var projectService = new ProjectService();
var createProjectCommand = new CreateProjectCommand(projectService);
var buttonTwo = new Button(createProjectCommand);

// Prints "Project Created".
buttonTwo.Click();
