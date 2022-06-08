using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    internal class IntersectLinkedList
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int inc;
            int counter1 = 0;
            int counter2 = 0;
            ListNode head1 = headA;
            ListNode head2 = headB;
            while (head1 != null || head2 != null)
            {
                if (head1 != null)
                {
                    head1 = head1.next;
                    counter1++;
                }
                if (head2 != null)
                {
                    head2 = head2.next;
                    counter2++;
                }
            }
            
            if (counter1 > counter2)
            {
                inc = counter1 - counter2;
                for (int i = 0; i < inc; i++)
                {
                    headA = headA.next;
                }
            }               
            else if (counter1 < counter2)
            {
                inc = counter2 - counter1;
                for (int i = 0; i < inc; i++)
                {
                    headB = headB.next;
                }                
            }                    
            while (headA != headB)
            {
                headA = headA.next;
                headB = headB.next;
            }
            return headA;
        }
    }
}
