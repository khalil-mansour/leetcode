using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            m--;
            n--;

            // start with the big values
            for (int i = m + n + 1; i >= 0; i--)
            {
                if (n < 0) break;
                if (m >= 0 && nums1[m] > nums2[n])
                {
                    nums1[i] = nums1[m];
                    m--;
                }
                else
                {
                    nums1[i] = nums2[n];
                    n--;
                }
            }
        }
    }
}
