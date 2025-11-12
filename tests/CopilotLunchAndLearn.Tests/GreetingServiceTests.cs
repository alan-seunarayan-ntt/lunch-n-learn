using CopilotLunchAndLearn.Core;

public class GreetingServiceTests
{
    [Fact]
    public void Greet_ReturnsHelloName_ForValidName()
    {
        var service = new GreetingService();
        var result = service.Greet("Alice");
        Assert.Equal("Hello, Alice!", result);
    }

    [Fact]
    public void Greet_ReturnsHello_ForNullOrWhitespace()
    {
        var service = new GreetingService();
        Assert.Equal("Hello!", service.Greet(null));
        Assert.Equal("Hello!", service.Greet("   "));
        Assert.Equal("Hello!", service.Greet(""));
    }
}
