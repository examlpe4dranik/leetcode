using System;

namespace RecursionI
{
    public static class OutputHelper
    {
        public static void Output(ListNode node)
        {
            if (node == null)
            {
                Console.Write("NULL");
                return;
            }

            Console.Write($"{node.val}");

            if (node.next != null)
            {
                Console.Write("-");
                Output(node.next);
            }
        }
    }
}