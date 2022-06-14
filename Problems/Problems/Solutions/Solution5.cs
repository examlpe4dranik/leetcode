using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solutions
{
    /// <summary>
    /// Longest Palindromic Substring
    /// </summary>
    public class Solution5 : ISolution
    {
        private Dictionary<string, bool> _cachePalindromes;

        public Solution5()
        {
            _cachePalindromes = new Dictionary<string, bool>();
        }

        public void Exec()
        {

            //Helper.Output(LongestPalindrome("babad"));
            //Helper.Output(LongestPalindrome("cbbd"));
            //Helper.Output(LongestPalindrome("lkuaergwein"));
            //Helper.Output(LongestPalindrome("annnnnna"));
            //Helper.Output(LongestPalindrome(string.Empty));
            //Helper.Output(LongestPalindrome(null));
            //Helper.Output(LongestPalindrome("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth"));
            Helper.Output(LongestPalindrome("zbkksfgesmfyuedjxdtknclymgskfjduhfocipzjqnmvcodjlvlagmhokqfeudickyeoobmkerjdeloxfbauryanltprloaeboavxzltgcurgbtgtpygpjizoopwmwjixaowppdvkferupefhwombszifyliidrxpxgcpbfzqtxdfiwfmtgvjiccrigwljrlvhaegvbitngckdnsfcnqlgykwjmsifcttcbeummaoidrrhkxmxctugcrlpbiolzqnjtwhzreruglrdvzioewcgvjjwfyqmhupusktptvfpcqxkvpbrlzchtacmlzgeejnvjzzhcegwtwqhimwooflzeiomeqyrnaeiquolmsunqrgffkpljewyritkivdrfnovbatdstypzsmbjdrromcqexnmjcuqpjzzjpqucjmnxeqcmorrdjbmszpytsdtabvonfrdviktirywejlpkffgrqnusmlouqieanryqemoiezlfoowmihqwtwgechzzjvnjeegzlmcathczlrbpvkxqcpfvtptksupuhmqyfwjjvgcweoizvdrlgurerzhwtjnqzloibplrcgutcxmxkhrrdioammuebcttcfismjwkyglqncfsndkcgntibvgeahvlrjlwgirccijvgtmfwifdxtqzfbpcgxpxrdiilyfizsbmowhfepurefkvdppwoaxijwmwpoozijpgyptgtbgrucgtlzxvaobeaolrptlnayruabfxoledjrekmbooeykciduefqkohmgalvljdocvmnqjzpicofhudjfksgmylcnktdxjdeuyfmsegfskkbz"));
        }

        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            {
            if (IsPalindrome(s))
                return s;
            }

            string longestPalindrome = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    var subString = s.Substring(i, j - i + 1);

                    if (subString.Length > longestPalindrome.Length)
                    {
                        if (IsPalindrome(subString))
                        {
                            longestPalindrome = subString;
                        }
                    }
                }
            }

            return longestPalindrome;
        }

        private bool IsPalindrome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else if (value.Length == 1)
            {
                return true;
            }

            if (value.Length > 2)
            {
                var firstSimbol = value.Substring(0, 1);
                var lasttSimbol = value.Substring(value.Length - 1, 1);
                if (firstSimbol != lasttSimbol)
                {
                    return false;
                }

                var core = value.Substring(1, value.Length - 2);

                if (_cachePalindromes.ContainsKey(core))
                {
                    _cachePalindromes.Add(value, _cachePalindromes[core]);
                    return _cachePalindromes[core];
                }

                var isPal = CheckPalindrome(core);
                if (isPal)
                {
                    _cachePalindromes.Add(value, isPal);
                }

                return isPal;
            }

            return CheckPalindrome(value);
        }

        private bool CheckPalindrome(string value)
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
