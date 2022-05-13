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

        public static void Output(TreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine($"{node.val} L:{Get(node.left)} R:{Get(node.right)}");
                Output(node.left);
                Output(node.right);
            }
        }

        private static string Get(TreeNode node) => node == null ? "null" : node.val.ToString();
    }
}