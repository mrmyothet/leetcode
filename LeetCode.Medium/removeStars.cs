using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium;

public class removeStars
{
    public static string solution(string input)
    {
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '*')
            {
                result = result.Substring(0, result.Length - 1);
            }
            else
            {
                result = result += input[i].ToString();
            }
        }

        return result;
    }
}
