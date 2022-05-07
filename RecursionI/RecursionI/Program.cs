using System;

namespace RecursionI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SwapNodesInPairs();

            Console.Read();
        }

        private static void SwapNodesInPairs()
        {
            var solution = new SwapNodesInPairs.Solution();

            var listNode = new SwapNodesInPairs.ListNode
            {
                val = 1,
                next = new SwapNodesInPairs.ListNode
                {
                    val = 2,
                    next = new SwapNodesInPairs.ListNode
                    {
                        val = 3,
                        next = new SwapNodesInPairs.ListNode
                        {
                            val = 4,
                            next = new SwapNodesInPairs.ListNode
                            {
                                val = 5
                            }
                        }
                    }
                }
            };

            Console.Write($"{listNode.val} - {listNode.next.val} - {listNode.next.next.val} - {listNode.next.next.next.val} - {listNode.next.next.next.next.val}");

            Console.WriteLine();

            var res = solution.SwapPairs(listNode);

            Console.Write($"{res.val} - {res.next.val} - {res.next.next.val} - {res.next.next.next.val} - {res.next.next.next.next.val}");
        }
    }
}