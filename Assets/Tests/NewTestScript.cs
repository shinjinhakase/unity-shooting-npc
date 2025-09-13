using NUnit.Framework;

public class NewTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScriptSimplePasses()
    {
        Assert.That(1 < 10);
    }

}
