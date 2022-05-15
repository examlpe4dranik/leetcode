using System;
using System.Linq;

namespace Problems
{
    public static class Helper
    {
        public static void Out(int[] ar)
        {
            var outstring = ar.ToList().Aggregate(string.Empty, (current, next) => $"{current},{next}");
            Console.WriteLine(outstring.Substring(1));
        }
    }
}