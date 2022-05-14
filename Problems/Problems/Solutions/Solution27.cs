using System;

namespace Problems.Solutions
{
    /// <summary>
    /// Remove Element
    /// </summary>
    public class Solution27 : ISolution
    {
        public void Exec()
        {
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            Console.WriteLine(RemoveElement(nums, 2));
            foreach (var el in nums)
            {
                Console.Write($"{el}-");
            }

            Console.WriteLine();

            var nums2 = new int[] { 3, 3 };
            Console.WriteLine(RemoveElement(nums2, 3));
            foreach (var el in nums2)
            {
                Console.Write($"{el}-");
            }
        }

        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0] == val ? 0 : 1;
            }

            int i = 0;
            int j = nums.Length - 1;
            do
            {
                if (nums[i] != val)
                {
                    i++;
                    continue;
                }
                else
                {
                    if (nums[j] == val)
                    {
                        j--;
                        continue;
                    }
                    else
                    {
                        nums[i] = nums[j];
                        nums[j] = val;
                        i++;
                        j--;
                    }
                }
            }
            while (i < j);

            int result = 0;
            i = 0;
            do
            {
                if (nums[i] == val)
                {
                    break;
                }
                result++;
                i++;
            }
            while (i < nums.Length);

            return result;
        }
    }
}