using System.Collections.Generic;

namespace Problems.Solutions
{
    /// <summary>
    /// Partition Labels
    /// </summary>
    public class Solution763 : ISolution
    {
        public void Exec()
        {
            Helper.Output(PartitionLabels("ababcbacadefegdehijhklij"));
            Helper.Output(PartitionLabels("eccbbbbdec"));
            Helper.Output(PartitionLabels("ogwhagwgiowrgwaugopwpopweigpwqiengovwebgowuihegogsnbcbxdvnbxcgsqaetweqegoiebgnowiubeoigbw"));
            Helper.Output(PartitionLabels("aaaaaaasaaaawwwwwewwwwrrrrrrtrrrr"));
        }

        public IList<int> PartitionLabels(string s)
        {
            var result = new List<int>();

            var maxIndex = this.maxIndex(s);

            int left = 0;
            int right = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > right)
                {
                    result.Add(right - left + 1);
                    left = i;
                    right = i;

                    if (i == s.Length - 1)
                    {
                        break;
                    }
                    i--;

                    continue;
                }

                if (maxIndex[s[i]] > i && maxIndex[s[i]] > right)
                {
                    right = maxIndex[s[i]];
                }
            }
            result.Add(s.Length - left);

            return result;
        }

        private Dictionary<char, int> maxIndex(string s)
        {
            var result = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!result.ContainsKey(s[i]))
                {
                    result.Add(s[i], -1);
                }

                result[s[i]] = result[s[i]] < i ? i : result[s[i]];
            }

            return result;
        }
    }
}