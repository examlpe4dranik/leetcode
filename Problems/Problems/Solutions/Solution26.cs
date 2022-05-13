using System;
using System.Collections.Generic;

namespace Problems.Solutions
{
    /// <summary>
    /// Remove Duplicates from Sorted Array
    /// </summary>
    public class Solution26 : ISolution
    {
        public void Exec()
        {
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(nums));
            foreach (var el in nums)
            {
                Console.Write($"{el}-");
            }
        }

        public int RemoveDuplicates(int[] nums)
        {
            int last = 0;
            var cache = new List<int>();
            cache.Add(nums[0]);
            for (int i = 0; i < nums.Length; i++)
            {
                if (cache[last] != nums[i])
                {
                    cache.Add(nums[i]);
                    last++;
                }
            }

            last = 0;
            for (int i = 0; i < cache.Count; i++)
            {
                nums[i] = cache[i];
                last = i;
            }

            return cache.Count;
        }
    }
}