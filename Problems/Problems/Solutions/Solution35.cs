using System;

namespace Problems.Solutions
{
    /// <summary>
    /// Search Insert Position
    /// </summary>
    public class Solution35 : ISolution
    {
        public void Exec()
        {
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
        }

        public int SearchInsert(int[] nums, int target)
        {
            if (nums[0] > target)
            {
                return 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }

                if (i == nums.Length - 1)
                {
                    return i + 1;
                }

                if (nums[i + 1] > target)
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}