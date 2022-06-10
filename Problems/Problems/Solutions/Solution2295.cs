using System.Collections.Generic;

namespace Problems.Solutions
{
    /// <summary>
    /// Replace Elements in an Array
    /// </summary>
    public class Solution2295 : ISolution
    {
        public void Exec()
        {
            Helper.Output(ArrayChange(new int[] { 1, 2, 4, 6 }, new int[][] { new int[] { 1, 3 }, new int[] { 4, 7 }, new int[] { 6, 1 } }));
            Helper.Output(ArrayChange(new int[] { 1, 2 }, new int[][] { new int[] { 1, 3 }, new int[] { 2, 1 }, new int[] { 3, 2 } }));
            Helper.Output(ArrayChange(new int[] { 1 }, new int[][] { new int[] { 1, 3 }, new int[] { 3, 5 } }));
        }

        public int[] ArrayChange(int[] nums, int[][] operations)
        {
            var mapper = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                mapper.Add(nums[i], i);
            }

            for (int i = 0; i < operations.Length; i++)
            {
                var indexCurrent = mapper[operations[i][0]];
                mapper.Remove(nums[indexCurrent]);
                nums[indexCurrent] = operations[i][1];
                mapper.Add(operations[i][1], indexCurrent);
            }

            return nums;
        }
    }
}