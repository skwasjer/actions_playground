namespace GhActions.Tests;

public class GreeterTests
{
    [Fact]
    public void Test()
    {
        Assert.Equal("Hello me", Greeter.Hello("me"));
    }
}
