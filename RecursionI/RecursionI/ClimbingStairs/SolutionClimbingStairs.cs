using System.Collections.Generic;

namespace RecursionI.ClimbingStairs
{
    public class SolutionClimbingStairs
    {
        private Dictionary<int, int> _cache { get; set; }

        public SolutionClimbingStairs()
        {
            _cache = new Dictionary<int, int>();
            _cache.Add(1, 1);
            _cache.Add(2, 2);
        }

        public int ClimbStairs(int n)
        {
            var cache = Cache(n);
            if (cache != null)
            {
                return (int)cache;
            }

            var r1 = ClimbStairs(n - 1);
            var r2 = ClimbStairs(n - 2);

            SetCache(n - 1, r1);
            SetCache(n - 2, r2);

            return r1 + r2;
        }

        private int? Cache(int n) => _cache.ContainsKey(n) ? _cache[n] : null;

        private void SetCache(int key, int val)
        {
            if (!_cache.ContainsKey(key))
            {
                _cache.Add(key, val);
            }
        }
    }
}