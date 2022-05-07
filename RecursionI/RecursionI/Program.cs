using System;
using RecursionI.SwapNodesInPairs;
using RecursionI.ReverseLinkedList;

namespace RecursionI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //SwapNodesInPairs();
            ReverseLinkedList();

            Console.Read();
        }

        private static void SwapNodesInPairs()
        {
            var solution = new SolutionSwapNodesInPairs();

            var listNode = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 3,
                        next = new ListNode
                        {
                            val = 4,
                            next = new ListNode
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

        private static void ReverseLinkedList()
        {
            var solution = new SolutionReverseLinkedList();

            var listNode = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 3,
                        next = new ListNode
                        {
                            val = 4,
                            next = new ListNode
                            {
                                val = 5
                            }
                        }
                    }
                }
            };

            Console.Write($"{listNode.val} - {listNode.next.val} - {listNode.next.next.val} - {listNode.next.next.next.val} - {listNode.next.next.next.next.val}");

            Console.WriteLine();

            var res = solution.ReverseList(listNode);

            Console.Write($"{res.val} - {res.next.val} - {res.next.next.val} - {res.next.next.next.val} - {res.next.next.next.next.val}");

        }
    }
}