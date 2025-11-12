namespace CopilotLunchAndLearn.Core;

public class GreetingService
{
    // Simple, predictable behavior for testing and demoing Copilot.
    // TODO (Copilot): Localize greeting or add time-based variations (morning/afternoon/evening).
    public string Greet(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            // Improvement idea: throw ArgumentException, or return a standardized error result type
            return "Hello!";
        }
        return $"Hello, {name}!";
    }
}

