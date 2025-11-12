using CopilotLunchAndLearn.Core;

public class MathUtilsTests
{
    [Fact]
    public void Add_ReturnsSum()
    {
        Assert.Equal(5, MathUtils.Add(2, 3));
    }

    [Fact]
    public void Subtract_ReturnsDifference()
    {
        Assert.Equal(-1, MathUtils.Subtract(2, 3));
    }

    [Fact]
    public void Multiply_ReturnsProduct()
    {
        Assert.Equal(6, MathUtils.Multiply(2, 3));
    }

    [Fact]
    public void Divide_ReturnsQuotient()
    {
        Assert.Equal(2, MathUtils.Divide(6, 3));
    }

    [Fact]
    public void Divide_ThrowsOnZero()
    {
        Assert.Throws<DivideByZeroException>(() => MathUtils.Divide(1, 0));
    }
}
