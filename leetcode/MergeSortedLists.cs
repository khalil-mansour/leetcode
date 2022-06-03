using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class MergeSortedLists
    {
        public ListNode Merge(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();
            ListNode head = result;

            while (true)
            {
                if (list1 == null)
                {
                    result.next = list2;
                    break;
                }
                if (list2 == null)
                {
                    result.next = list1;
                    break;
                }

                if (list1.val <= list2.val)
                {
                    result.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    result.next = list2;
                    list2 = list2.next;
                }
                result = result.next;
            }
            return head.next;
        }
    }
}
