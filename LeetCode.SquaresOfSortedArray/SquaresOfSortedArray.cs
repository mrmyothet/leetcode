using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SquaresOfSortedArray;

public class SquaresOfSortedArray
{
    public static int[] SortedSquares(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        int L = 0;
        int R = n - 1;

        int index = n - 1;

        while (L <= R)
        {
            int left = nums[L] * nums[L];
            int right = nums[R] * nums[R];

            if (left > right)
            {
                result[index] = left;
                L++;
            }

            if (left <= right)
            {
                result[index] = right;
                R--;
            }

            index--;
        }

        return result;
    }
}
