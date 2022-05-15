namespace Problems.Solutions
{
    /// <summary>
    /// Two Sum
    /// </summary>
    public class Solution1 : ISolution
    {
        public void Exec()
        {
            Helper.Out(TwoSum(new int[] { 2, 7, 11, 15 }, 9));
            Helper.Out(TwoSum(new int[] { 3, 2, 4 }, 6));
            Helper.Out(TwoSum(new int[] { 3, 3 }, 6));
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return null;
        }
    }
}