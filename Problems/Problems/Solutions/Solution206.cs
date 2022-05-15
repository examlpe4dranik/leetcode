using Problems.Model;
using System;

namespace Problems.Solutions
{
    /// <summary>
    /// Reverse Linked List
    /// </summary>
    public class Solution206 : ISolution
    {
        public void Exec()
        {
            Helper.Output(ReverseList(new ListNode { val = 1, next = new ListNode { val = 2, next = new ListNode { val = 3, next = new ListNode { val = 4, next = new ListNode { val = 5 } } } } }));
            Console.WriteLine();

            Helper.Output(ReverseList(new ListNode { val = 1, next = new ListNode { val = 2 } }));
            Console.WriteLine();

            Helper.Output(ReverseList(null));
            Console.WriteLine();
        }

        public ListNode ReverseList(ListNode head)
        {
            if (head != null && head.next != null)
            {
                return ReverseList(head, null);
            }
            else
            {
                return head;
            }
        }

        private ListNode ReverseList(ListNode node, ListNode prewNode)
        {
            if (node != null)
            {
                var newNode = new ListNode { val = node.val, next = prewNode };
                return ReverseList(node.next, newNode);
            }
            else
            {
                return prewNode;
            }
        }
    }
}