using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionI.UniqueBinarySearchTreesII
{
    public class SolutionUniqueBinarySearchTreesII
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            var result = new List<TreeNode>();

            for (int i = 0; i <= n; i++)
            {
                result.AddRange(GenerateTrees(n -1));
            }

            return result;
        }
    }
}
