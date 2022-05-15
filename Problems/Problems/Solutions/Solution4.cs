using System;
using System.Linq;

namespace Problems.Solutions
{
    /// <summary>
    /// Median of Two Sorted Arrays
    /// </summary>
    public class Solution4 : ISolution
    {
        public void Exec()
        {
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }));
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 }));
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var workList = nums1.ToList();
            workList.AddRange(nums2.ToList());
            workList.Sort();

            double result;
            if (workList.Count() % 2 == 0)
            {
                result = (workList[(workList.Count() / 2) - 1] + workList[workList.Count() / 2]) / 2.0;
            }
            else
            {
                result = workList[((int)Math.Truncate((decimal)(workList.Count() / 2)))];
            }

            return result;
        }
    }
}