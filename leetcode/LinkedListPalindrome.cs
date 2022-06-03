using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class LinkedListPalindrome
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode firstElem = head;
            Stack<int> pali = new Stack<int>();
            while (head.next != null)
            {
                pali.Push(head.val);
                head = head.next;
            }
            pali.Push(head.val);
            head = firstElem;
            while (head.next != null)
            {
                if (pali.Pop() != head.val)
                    return false;
                head = head.next;
            }
            return true;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
