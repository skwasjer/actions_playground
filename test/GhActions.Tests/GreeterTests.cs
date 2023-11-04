namespace GhActions.Tests;

public class GreeterTests
{
    [Fact]
    public void Test()
    {
        Assert.Equal("Hello you", Greeter.Hello("you"));
    }
}
