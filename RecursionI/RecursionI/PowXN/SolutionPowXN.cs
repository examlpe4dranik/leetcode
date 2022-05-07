namespace RecursionI.PowXN
{
    public class SolutionPowXN
    {
        public double MyPow(double x, int n)
        {
            if (n == 0 || x == 1)
            {
                return 1;
            }

            if (x == -1)
            {
                if (n == int.MinValue)
                {
                    return 1;
                }

                return -1;
            }

            return CurrentPow(x, x, n);
        }

        private double CurrentPow(double current, double x, int n)
        {
            if (!double.IsNormal(current))
            {
                return 0.0;
            }

            if (current == 0.0)
            {
                return 0.0;
            }

            if (n == 1)
            {
                return current;
            }

            if (n == -1)
            {
                return 1 / current;
            }

            if (n < 0)
            {
                return CurrentPow(current * x, x, n + 1);
            }
            else
            {
                return CurrentPow(current * x, x, n - 1);
            }
        }
    }
}