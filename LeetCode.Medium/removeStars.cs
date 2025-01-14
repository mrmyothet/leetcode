using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium;

public class removeStars
{
    // Time Limit Exceeded - ERROR in leetcode
    //public static string solution(string input)
    //{
    //    string result = "";

    //    for (int i = 0; i < input.Length; i++)
    //    {
    //        if (input[i] == '*')
    //        {
    //            result = result.Substring(0, result.Length - 1);
    //        }
    //        else
    //        {
    //            result = result += input[i].ToString();
    //        }
    //    }

    //    return result;
    //}

    public static string solution(string input)
    {
        string result = "";
        Stack<char> charStack = new Stack<char>();

        for (int i = 0; i < input.Length; i++)
        {
            char element = input[i];
            if (charStack is not null && element == '*')
            {
                charStack.Pop();
            }
            else
            {
                charStack.Push(element);
            }
        }

        Stack<char> reverseStack = new Stack<char>();
        while (charStack.Count > 0)
        {
            reverseStack.Push(charStack.Pop());
        }

        return String.Join("", reverseStack);
    }
}
