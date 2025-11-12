using CopilotLunchAndLearn.Core;
using Xunit;

namespace CopilotLunchAndLearn.Tests;

public class MathUtilsTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 2, 1)]
    [InlineData(1.5, 2.5, 4.0)]
    public void Add_ReturnsSum(double a, double b, double expected)
    {
        var result = MathUtils.Add(a, b);
        Assert.Equal(expected, result, precision: 10);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(-1, -2, 1)]
    [InlineData(1.5, 0.5, 1.0)]
    public void Subtract_ReturnsDifference(double a, double b, double expected)
    {
        var result = MathUtils.Subtract(a, b);
        Assert.Equal(expected, result, precision: 10);
    }

    [Theory]
    [InlineData(3, 2, 6)]
    [InlineData(-1, 2, -2)]
    [InlineData(1.5, 2.0, 3.0)]
    public void Multiply_ReturnsProduct(double a, double b, double expected)
    {
        var result = MathUtils.Multiply(a, b);
        Assert.Equal(expected, result, precision: 10);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(-6, 2, -3)]
    [InlineData(4.5, 1.5, 3.0)]
    public void Divide_ReturnsQuotient(double a, double b, double expected)
    {
        var result = MathUtils.Divide(a, b);
        Assert.Equal(expected, result, precision: 10);
    }

    [Fact]
    public void Divide_ByZero_Throws()
    {
        Assert.Throws<DivideByZeroException>(() => MathUtils.Divide(1, 0));
    }
}
