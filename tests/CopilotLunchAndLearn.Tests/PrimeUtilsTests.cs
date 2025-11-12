using CopilotLunchAndLearn.Core;

public class PrimeUtilsTests
{
    [Fact]
    public void IsPrimeInefficient_WorksForKnownValues()
    {
        Assert.False(PrimeUtils.IsPrimeInefficient(0));
        Assert.False(PrimeUtils.IsPrimeInefficient(1));
        Assert.True(PrimeUtils.IsPrimeInefficient(2));
        Assert.True(PrimeUtils.IsPrimeInefficient(3));
        Assert.False(PrimeUtils.IsPrimeInefficient(4));
        Assert.True(PrimeUtils.IsPrimeInefficient(5));
        Assert.False(PrimeUtils.IsPrimeInefficient(9));
    }

    [Fact]
    public void GetPrimesUpToInefficient_ReturnsCorrectList()
    {
        var primes = PrimeUtils.GetPrimesUpToInefficient(10);
        Assert.Equal(new List<int> {2, 3, 5, 7}, primes);
    }
}
