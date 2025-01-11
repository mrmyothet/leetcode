namespace NeetCode.Easy;

public class Sqrtx
{
    public static int Sqrt(int input)
    {
        int left = 0;
        int right = input;
        int result = 0;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (middle * middle > input)
            {
                right = middle - 1;
            }
            else if (middle * middle < input)
            {
                left = middle + 1;
                result = middle;
            }
            else
            {
                return middle;
            }
        }

        return result;
    }
}