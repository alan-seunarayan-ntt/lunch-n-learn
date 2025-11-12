namespace CopilotLunchAndLearn.Core;

public static class MathUtils
{
    // Keep methods small and deterministic for teaching testing with Copilot.
    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }
        return a / b;
    }

    // TODO (Copilot): Add Sum(IEnumerable<double>) and handle null/empty gracefully
}
