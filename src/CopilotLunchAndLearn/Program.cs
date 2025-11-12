using System.CommandLine;
using CopilotLunchAndLearn.Core;

// Now using System.CommandLine for clearer parsing and help.
// Improvement ideas (great for Copilot):
// - Add global options like --format json
// - Add logging with Microsoft.Extensions.Logging
// - Add validation attributes and custom error messages

var root = new RootCommand("Copilot Lunch & Learn CLI");

// greet <name>
var nameArg = new Argument<string>(
    name: "name",
    description: "Name to greet");
var greetCmd = new Command("greet", "Prints a friendly greeting")
{
    nameArg
};
greetCmd.SetHandler((string name) =>
{
    var service = new GreetingService();
    var message = service.Greet(name);
    Console.WriteLine(message);
}, nameArg);

// calc command with subcommands: add/subtract/multiply/divide
var calcCmd = new Command("calc", "Simple calculator operations");

Argument<double> aArg(string desc) => new(name: "a", description: desc);
Argument<double> bArg(string desc) => new(name: "b", description: desc);

Command MakeBinaryOp(string name, string description, Func<double, double, double> op)
{
    var a = aArg("First number");
    var b = bArg("Second number");
    var cmd = new Command(name, description) { a, b };
    cmd.SetHandler((double a, double b) =>
    {
        try
        {
            var result = op(a, b);
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.Error.WriteLine("Error: Division by zero is not allowed.");
            Environment.ExitCode = 1;
        }
    }, a, b);
    return cmd;
}

calcCmd.AddCommand(MakeBinaryOp("add", "Adds two numbers", MathUtils.Add));
calcCmd.AddCommand(MakeBinaryOp("subtract", "Subtracts b from a", MathUtils.Subtract));
calcCmd.AddCommand(MakeBinaryOp("multiply", "Multiplies two numbers", MathUtils.Multiply));
calcCmd.AddCommand(MakeBinaryOp("divide", "Divides a by b", MathUtils.Divide));

root.AddCommand(greetCmd);
root.AddCommand(calcCmd);

return await root.InvokeAsync(args);
