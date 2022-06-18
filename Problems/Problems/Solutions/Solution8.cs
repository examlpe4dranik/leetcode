namespace Problems.Solutions
{
    /// <summary>
    /// String to Integer (atoi)
    /// </summary>
    public class Solution8 : ISolution
    {
        public void Exec()
        {
            Helper.Output(MyAtoi(null));
            Helper.Output(MyAtoi(string.Empty));
            Helper.Output(MyAtoi("0"));
            Helper.Output(MyAtoi("42"));
            Helper.Output(MyAtoi("4193 with words"));
            Helper.Output(MyAtoi("-23432 sdf sd sdf "));
            Helper.Output(MyAtoi("+23432 sdf sd sdf"));
            Helper.Output(MyAtoi(" - 42"));
            Helper.Output(MyAtoi("-91283472332"));
            Helper.Output(MyAtoi("91283472332"));
            Helper.Output(MyAtoi("20000000000000000000"));
            Helper.Output(MyAtoi("  0000000000012345678"));
            Helper.Output(MyAtoi(".1"));
            Helper.Output(MyAtoi("   +0 123"));
            Helper.Output(MyAtoi("-000000000000001"));
            Helper.Output(MyAtoi("+"));
            Helper.Output(MyAtoi("1"));
            Helper.Output(MyAtoi("  +  413"));
        }

        public int MyAtoi(string s)
        {
            int digit = 0;

            if (!string.IsNullOrWhiteSpace(s))
            {
                string str = s.Trim();
                string plusMinus = string.Empty;

                int i = 0;
                if (IsMinusPlus(str[i]))
                {
                    if (str.Length == 1)
                    {
                        return digit;
                    }

                    plusMinus = str[i].ToString();
                    i++;
                }

                string value = string.Empty;
                while (i < str.Length && IsDigit(str[i]))
                {
                    value += str[i];
                    i++;
                }

                value = plusMinus + value.TrimStart('0');

                if (value.Length > 0)
                {
                    if (value.Length > 11)
                    {
                        if (value[0] == '-')
                        {
                            digit = int.MinValue;
                        }
                        else
                        {
                            digit = int.MaxValue;
                        }
                    }
                    else
                    {
                        long.TryParse(value, out long checkDigit);
                        if (checkDigit < int.MinValue)
                        {
                            digit = int.MinValue;
                        }
                        else if (checkDigit > int.MaxValue)
                        {
                            digit = int.MaxValue;
                        }
                        else
                        {
                            digit = (int)checkDigit;
                        }
                    }
                }
            }

            return digit;
        }

        private bool IsMinusPlus(char val) => val == '-' || val == '+';

        private bool IsDigit(char val) =>
            val == '0' || val == '1' || val == '2' || val == '3' || val == '4' || val == '5' || val == '6' || val == '7' || val == '8' || val == '9';
    }
}