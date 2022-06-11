using System.Collections.Generic;

namespace Problems.Solutions
{
    /// <summary>
    /// Longest Substring Without Repeating Characters
    /// </summary>
    public class Solution3 : ISolution
    {
        public void Exec()
        {
            Helper.Output(LengthOfLongestSubstring("abcabcbb"));
            Helper.Output(LengthOfLongestSubstring("bbbbb"));
            Helper.Output(LengthOfLongestSubstring("pwwkew"));
            Helper.Output(LengthOfLongestSubstring("aab"));
            Helper.Output(LengthOfLongestSubstring("dvdf"));
            Helper.Output(LengthOfLongestSubstring(string.Empty));
        }

        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            var cache = new Dictionary<char, bool>();
            int i;
            int lastIndex = 0;
            int maxLen = 0;
            int currentLen = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (cache.ContainsKey(s[i]))
                {
                    cache.Clear();
                    CheckMaxLen(ref currentLen, ref maxLen);
                    currentLen = 0;

                    i = lastIndex;
                }
                else
                {
                    if (cache.Count == 0)
                    {
                        lastIndex = i;
                    }
                    cache.Add(s[i], false);
                    currentLen++;
                }

                if (i == s.Length - 1)
                {
                    CheckMaxLen(ref currentLen, ref maxLen);
                }
            }

            return maxLen;
        }

        private void CheckMaxLen(ref int currentLen, ref int maxLen)
        {
            if (currentLen > maxLen)
            {
                maxLen = currentLen;
            }
        }
    }
}