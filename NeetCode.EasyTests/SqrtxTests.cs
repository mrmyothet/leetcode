namespace NeetCode.EasyTests;

using NeetCode.Easy;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_4()
    {
        int result = Sqrtx.Sqrt(4);
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Test_8()
    {
        int result = Sqrtx.Sqrt(8);
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Test_10000()
    {
        int result = Sqrtx.Sqrt(10000);
        Assert.That(result, Is.EqualTo(100));
    }
}