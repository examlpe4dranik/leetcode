using Problems.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class Helper
    {
        public static void Output(int digit)
        {
            Console.WriteLine($"{nameof(digit)}={digit}");
        }

        public static void Output(int[] ar)
        {
            var outstring = ar.ToList().Aggregate(string.Empty, (current, next) => $"{current},{next}");
            Console.WriteLine(outstring.Substring(1));
        }

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

        public static void Output(IList<int> list)
        {
            foreach (var sheet in list)
            {
                Console.Write($"{sheet}-");
            }
            Console.WriteLine();
        }
    }
}