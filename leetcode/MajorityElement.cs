using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class MajorityElement
    {
        public int Majority(int[] nums)
        {
            int counter = 0;
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (counter == 0)
                {
                    result = nums[i];
                    counter = 1;
                }
                else if (result == nums[i])
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }
            return result;
        }
    }
}
