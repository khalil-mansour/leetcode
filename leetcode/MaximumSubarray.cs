using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class MaximumSubarray
    {
        public int MaxSub(int[] nums)
        {
            int currentSum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                // sum = sum + next number
                currentSum += nums[i];
                // if sum is higher or equal to max value, the max value becomes sum
                maxSum = Math.Max(currentSum, maxSum);
                // if the current number is higher than the sum, sum becomes the current number
                if (currentSum < 0)
                    currentSum = 0;
            }
            return maxSum;       
        }
    }
}
