using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class MiddleLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode middle = head;
            int index = 0;
            while (head != null)
            {
                if ((index + 1) % 2 == 0)
                    middle = middle.next;
                head = head.next;
                index++;
            }
            return middle;           
        }
    }
}
