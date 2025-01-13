namespace LeetCode.Arrays;

public class GetConcatenation
{
    public static int[] GetConcatenationArray(int[] nums)
    {
        int length = nums.Length * 2;
        int[] result = new int[length];
        int index = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                result[index] = nums[j];
                index++;
            }
        }
        return result;
    }
}
