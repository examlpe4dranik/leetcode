namespace Problems.Solutions
{
    /// <summary>
    /// Regular Expression Matching
    /// </summary>
    public class Solution10 : ISolution
    {
        public void Exec()
        {
            Helper.Output(IsMatch("aa", "a"));
            Helper.Output(IsMatch("aa", "a*"));
            Helper.Output(IsMatch("ab", ".*"));
        }

        public bool IsMatch(string s, string p)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(s, $"^{p}$");
        }
    }
}