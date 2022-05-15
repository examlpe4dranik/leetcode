using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Solutions
{
    /// <summary>
    /// Single Number
    /// </summary>
    public class Solution136 : ISolution
    {
        public void Exec()
        {
            Console.WriteLine(SingleNumber(new int[] { 2, 2, 1 }));
            Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
            Console.WriteLine(SingleNumber(new int[] { 1 }));
        }

        public int SingleNumber(int[] nums)
        {
            Dictionary<int, bool> cache = new Dictionary<int, bool>();

            foreach (var el in nums)
            {
                if (cache.ContainsKey(el))
                {
                    cache.Remove(el);
                }
                else
                {
                    cache.Add(el, true);
                }
            }

            return cache.First().Key;
        }
    }
}