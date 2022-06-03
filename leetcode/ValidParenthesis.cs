using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcode
{
    internal class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> res = new Dictionary<char, char>();
            res.Add(')', '(');
            res.Add('}', '{');
            res.Add(']', '[');

            Stack<char> opening = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (res.ContainsKey(s[i]))
                {
                    if (opening.TryPeek(out _))
                    {
                        if (opening.Pop() != res[s[i]])
                            return false;
                    }
                    else return false;
                }
                else
                {
                    opening.Push(s[i]);
                }
            }
            return opening.Count == 0;
        }
    }


}
