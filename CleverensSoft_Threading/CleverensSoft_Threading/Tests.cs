using NUnit.Framework;

[TestFixture]
class Tests
{
    [Test]
    public void Run_ShouldNotThrowException()
    {
        var client = new Client();
        var stringWriter = new StringWriter();
        Assert.DoesNotThrow(() => client.Run());
    }
}