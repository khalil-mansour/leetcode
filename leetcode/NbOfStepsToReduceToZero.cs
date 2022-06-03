using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class NbOfStepsToReduceToZero
    {
        public int Steps(int num)
        {
            int steps = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                    num = num / 2;
                else
                    num--;
                steps++;
            }
            return steps;
        }
    }
}
