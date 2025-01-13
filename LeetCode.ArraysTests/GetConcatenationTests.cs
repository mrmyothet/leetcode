using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Arrays;

namespace LeetCode.ArraysTests;

public class GetConcatenationTests
{
    [Test]
    public void Test_Example_1()
    {
        int[] nums = [1, 2, 1];
        int[] expected = [1, 2, 1, 1, 2, 1];

        int[] result = GetConcatenation.GetConcatenationArray(nums);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Example_2()
    {
        int[] nums = [1, 3, 2, 1];
        int[] expected = [1, 3, 2, 1, 1, 3, 2, 1];

        int[] result = GetConcatenation.GetConcatenationArray(nums);

        Assert.That(result, Is.EqualTo(expected));
    }
}
