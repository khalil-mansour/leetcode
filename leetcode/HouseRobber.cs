using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];

            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            int[] res = new int[nums.Length];

            res[0] = nums[0];
            res[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                res[i] = Math.Max(nums[i] + res[i - 2], res[i - 1]);
            }
            return res[^1];
        }
    }
}
