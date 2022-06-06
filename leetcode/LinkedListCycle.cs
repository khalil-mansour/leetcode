using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while (fast != null)
            {
                if (fast.next == null)
                {
                    return false;
                }
                else
                {
                    fast = fast.next.next;
                }
                slow = slow.next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
