using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class FizzBuzz
    {
        public IList<string> FBResult(int n)
        {
            string[] fb = new string[n];

            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
                    fb[i] = "FizzBuzz";
                else if ((i + 1) % 3 == 0)
                    fb[i] = "Fizz";
                else if ((i + 1) % 5 == 0)
                    fb[i] = "Buzz";
                else
                    fb[i] = (i + 1).ToString();
            }
            return fb;
        }
    }
}
