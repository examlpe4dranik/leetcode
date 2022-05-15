using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Model;

namespace Problems.Solutions
{
    /// <summary>
    /// Merge Two Sorted Lists
    /// </summary>
    public class Solution21 : ISolution
    {
        public void Exec()
        {
            var list1 = new ListNode { val = 1, next = new ListNode { val = 2, next = new ListNode { val = 4 } } };
            var list2 = new ListNode { val = 1, next = new ListNode { val = 3, next = new ListNode { val = 4 } } };
            Helper.Output(MergeTwoLists(list1, list2));
            Console.WriteLine();

            Helper.Output(MergeTwoLists(null, null));
            Console.WriteLine();

            Helper.Output(MergeTwoLists(null, new ListNode { val = 0 }));
            Console.WriteLine();

            var list3 = new ListNode { val = 1, next = new ListNode { val = 1, next = new ListNode { val = 9 } } };
            var list4 = new ListNode { val = 2, next = new ListNode { val = 3 } };
            Helper.Output(MergeTwoLists(list3, list4));
            Console.WriteLine();
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }

            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            if (list1.val <= list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
}
