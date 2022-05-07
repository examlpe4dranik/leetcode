using System;
using RecursionI.SwapNodesInPairs;
using RecursionI.ReverseLinkedList;
using RecursionI.SearchInABinarySearchTree;
using RecursionI.PascalsTriangleII;

namespace RecursionI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //SwapNodesInPairs();
            //ReverseLinkedList();
            //SearchInABinarySearchTree();
            PascalsTriangleII();

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

        private static void SearchInABinarySearchTree()
        {
            var sol = new SolutionSearchInABinarySearchTree();

            var tree = new TreeNode
            {
                val = 4,
                left = new TreeNode
                {
                    val = 2,
                    left = new TreeNode { val = 1 },
                    right = new TreeNode { val = 3 }
                },
                right = new TreeNode { val = 7 }
            };

            var result = sol.SearchBST(tree, 2);
        }

        private static void PascalsTriangleII()
        {
            var sol = new SolutionPascalsTriangleII();

            ExecuteTaseCase(sol, 0);
            ExecuteTaseCase(sol, 1);
            ExecuteTaseCase(sol, 2);
            ExecuteTaseCase(sol, 3);
            ExecuteTaseCase(sol, 4);
            ExecuteTaseCase(sol, 5);
            ExecuteTaseCase(sol, 6);
            ExecuteTaseCase(sol, 7);
            ExecuteTaseCase(sol, 8);

            static void ExecuteTaseCase(SolutionPascalsTriangleII solution, int rowIndex)
            {
                var res = solution.GetRow(rowIndex);
                foreach (var item in res)
                {
                    Console.Write($"{item},");
                }
                Console.WriteLine();
            }
        }
    }
}