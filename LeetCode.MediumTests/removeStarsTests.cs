namespace LeetCode.MediumTests;

using LeetCode.Medium;

[TestFixture]
public class removeStarsTests
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void Test_Example_1()
    {
        string input = "leet**cod*e";
        string expected = "lecoe";

        string result = removeStars.solution(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Example_2()
    {
        string input = "erase*****";
        string expected = "";

        string result = removeStars.solution(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
