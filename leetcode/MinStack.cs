using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class MinStack
    {
        ListNode head;
        ListNode mins;
        int minVal = int.MaxValue;

        public MinStack()
        {
        }

        public void Push(int val)
        {
            ListNode newNode = new ListNode(val);

            if (head == null)
                head = newNode;
            else
            {
                ListNode temp = head;
                head = newNode;
                newNode.next = temp;
            }

            if (val <= minVal)
            {
                minVal = val;
                ListNode newMin = new ListNode(val);

                if (mins == null)
                    mins = newMin;
                else
                {
                    ListNode temp = mins;
                    mins = newMin;
                    newMin.next = temp;
                }
            }
        }

        public void Pop()
        {
            if (head.val == mins.val)
            {
                mins = mins.next;
                if (mins == null)
                    minVal = int.MaxValue;
                else
                    minVal = mins.val;
            }

            if (mins == null)
                minVal = int.MaxValue;
            head = head.next;
        }

        public int Top()
        {
            return head.val;
        }

        public int GetMin()
        {
            return mins.val;
        }
    }
}
