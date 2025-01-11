namespace LeetCode.ArraysTests;

using LeetCode.SquaresOfSortedArray;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_BaseCase()
    {
        int[] arr = { 1, 2, 3, 4, 5};
        int[] result = SquaresOfSortedArray.SortedSquares(arr);
        
        int[] expected = { 1, 4, 9, 16, 25};
        Assert.That(result, Is.EqualTo(expected));
    }
}