namespace Problems.Solutions
{
    /// <summary>
    /// Palindrome Number
    /// </summary>
    public class Solution9 : ISolution
    {
        public void Exec()
        {
            Helper.Output(IsPalindrome(121));
            Helper.Output(IsPalindrome(983498732));
            Helper.Output(IsPalindrome(0));
            Helper.Output(IsPalindrome(-123));
            Helper.Output(IsPalindrome(-121));
        }

        public bool IsPalindrome(int x)
        {
            return IsPalindrome(x.ToString());
        }

        private bool IsPalindrome(string value)
        {
            int left = 0;
            int right = value.Length - 1;

            while (left < right)
            {
                if (value[left] != value[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}