using Problems.Model;
using System;

namespace Problems.Solutions
{
    /// <summary>
    /// Swap Nodes in Pairs
    /// </summary>
    public class Solution24 : ISolution
    {
        public void Exec()
        {
            Helper.Output(SwapPairs(new ListNode { val = 2, next = new ListNode { val = 1, next = new ListNode { val = 4, next = new ListNode { val = 3 } } } }));
            Console.WriteLine();

            Helper.Output(SwapPairs(null));
            Console.WriteLine();

            Helper.Output(SwapPairs(new ListNode { val = 1 }));
            Console.WriteLine();

            Helper.Output(SwapPairs(new ListNode { val = 1, next = new ListNode { val = 2, next = new ListNode { val = 3, next = new ListNode { val = 4, next = new ListNode { val = 5 } } } } }));
            Console.WriteLine();
        }

        public ListNode SwapPairs(ListNode node)
        {
            if (node == null || node.next == null)
            {
                return node;
            }

            var tmp = node.val;
            node.val = node.next.val;
            node.next.val = tmp;

            SwapPairs(node.next.next);

            return node;
        }
    }
}