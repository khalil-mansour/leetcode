using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class FactorialTrailingZeroes
    {
        public int TrailingZeroes(int n)
        {
            // find the factors of 5
            int answer = 0;

            while (n >= 5)
            {
                answer += n / 5;
                n = n / 5;
            }
            return answer;
        }
    }
}
