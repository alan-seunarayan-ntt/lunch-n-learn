using CopilotLunchAndLearn.Core;
using Xunit;

namespace CopilotLunchAndLearn.Tests;

public class GreetingServiceTests
{
    [Fact]
    public void Greet_WithName_ReturnsPersonalGreeting()
    {
        var svc = new GreetingService();
        var result = svc.Greet("Alice");
        Assert.Equal("Hello, Alice!", result);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData(null)]
    public void Greet_EmptyOrNull_ReturnsGenericGreeting(string? name)
    {
        var svc = new GreetingService();
        var result = svc.Greet(name ?? string.Empty);
        Assert.Equal("Hello!", result);
    }
}

