using Problems.Model;
using System;

namespace Problems.Solutions
{
    /// <summary>
    /// Add Two Numbers
    /// </summary>
    public class Solution2 : ISolution
    {
        public void Exec()
        {
            var l1 = new ListNode { val = 2, next = new ListNode { val = 4, next = new ListNode { val = 3 } } };
            var l2 = new ListNode { val = 5, next = new ListNode { val = 6, next = new ListNode { val = 4 } } };
            Helper.Output(AddTwoNumbers(l1, l2));
            Console.WriteLine();

            Helper.Output(AddTwoNumbers(null, null));
            Console.WriteLine();

            var l3 = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9 } } } } } } };
            var l4 = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9 } } } };
            Helper.Output(AddTwoNumbers(l3, l4));
            Console.WriteLine();
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int added = 0)
        {
            int summa = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + added;
            int val = summa >= 10 ? summa - 10 : summa;
            int addedNext = summa >= 10 ? 1 : 0;

            if (l1 == null && l2 == null)
            {
                return val == 0 ? null : new ListNode { val = val };
            }
            else
            {
                return new ListNode { val = val, next = AddTwoNumbers(l1 == null ? null : l1.next, l2 == null ? null : l2.next, addedNext) };
            }
        }
    }
}