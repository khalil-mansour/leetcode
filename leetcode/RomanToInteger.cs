using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class RomanToInteger
    {
        public int Convert(string s)
        {
            int sum = 0;
            char p;
            char c;
            for (int x = s.Length - 1; x >= 0; x--)
            {
                if (x == s.Length - 1)
                    p = 'A';
                else
                    p = s[x + 1];
                c = s[x];
                switch (c)
                {
                    case 'M':
                        sum += 1000;
                        break;
                    case 'D':
                        sum += 500;
                        break;
                    case 'C':
                        if (p == 'M' || p == 'D')
                            sum -= 100;
                        else
                            sum += 100;
                        break;
                    case 'L':
                        sum += 50;
                        break;
                    case 'X':
                        if (p == 'L' || p == 'C')
                            sum -= 10;
                        else
                            sum += 10;
                        break;
                    case 'V':
                        sum += 5;
                        break;
                    case 'I':
                        if (p == 'V' || p == 'X')
                            sum--;
                        else
                            sum++;
                        break;
                }
            }
            return sum;
        }
    }
}
