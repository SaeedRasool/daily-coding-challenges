using System;
using System.Collections.Generic;

public class Solution
{
    public static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> map = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char c in s)
        {
            if (map.ContainsValue(c))
            {
                stack.Push(c);
            }
            else if (map.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Pop() != map[c])
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
