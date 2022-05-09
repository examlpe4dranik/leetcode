using System;

namespace RecursionI.KthSymbolInGrammar
{
    public class SolutionKthSymbolInGrammar
    {
        public int KthGrammar(int n, int k)
        {
            if (n == 1 && k == 1)
            {
                return 0;
            }

            var mid = (int)Math.Pow(2, n - 1) / 2;

            if (k <= mid)
            {
                return KthGrammar(n - 1, k);
            }
            else
            {
                return Inverce(KthGrammar(n - 1, k - mid));
            }
        }

        private int Inverce(int value) => value == 0 ? 1 : 0;
    }
}