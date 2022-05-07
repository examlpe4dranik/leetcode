using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionI.MaximumDepthOfBinaryTree
{
    public class SolutionMaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root) => root == null ? 0 : CurrentDepth(root, 1);

        private int CurrentDepth(TreeNode node, int depth)
        {
            if (node.left == null && node.right == null)
            {
                return depth;
            }
            else
            {
                int leftDepth = node.left == null ? 0 : CurrentDepth(node.left, depth + 1);
                int rightDepth = node.right == null ? 0 : CurrentDepth(node.right, depth + 1);

                return leftDepth > rightDepth ? leftDepth : rightDepth;
            }
        }
    }
}
