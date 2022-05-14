using System.Collections.Generic;

namespace RecursionI.UniqueBinarySearchTreesII
{
    public class SolutionUniqueBinarySearchTreesII
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0)
            {
                return new List<TreeNode>();
            }

            return GenerateTrees(1, n);
        }

        private IList<TreeNode> GenerateTrees(int from, int to)
        {
            if (from > to)
            {
                return new List<TreeNode>();
            }

            if (from == to)
            {
                return new List<TreeNode> { new TreeNode(from) };
            }

            IList<TreeNode> result = new List<TreeNode>();
            for (int i = from; i <= to; ++i)
            {
                IList<TreeNode> leftTrees = GenerateTrees(from, i - 1);
                IList<TreeNode> rightTrees = GenerateTrees(i + 1, to);

                if (leftTrees.Count == 0)
                {
                    foreach (TreeNode r in rightTrees)
                    {
                        TreeNode root = new TreeNode(i);
                        root.right = r;
                        result.Add(root);
                    }
                }

                if (rightTrees.Count == 0)
                {
                    foreach (TreeNode l in leftTrees)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = l;
                        result.Add(root);
                    }
                }

                foreach (TreeNode left in leftTrees)
                {
                    foreach (TreeNode right in rightTrees)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = left;
                        root.right = right;
                        result.Add(root);
                    }
                }
            }

            return result;
        }
    }
}