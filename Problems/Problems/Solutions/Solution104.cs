using Problems.Model;
using System;

namespace Problems.Solutions
{
    /// <summary>
    /// Maximum Depth of Binary Tree
    /// </summary>
    public class Solution104 : ISolution
    {
        public void Exec()
        {
            var tree1 = new TreeNode { val = 3, left = new TreeNode { val = 9 }, right = new TreeNode { val = 20, left = new TreeNode { val = 15 }, right = new TreeNode { val = 7 } } };
            Console.WriteLine(MaxDepth(tree1));

            Console.WriteLine(MaxDepth(new TreeNode { val = 1, right = new TreeNode { val = 2 } }));

            Console.WriteLine(MaxDepth(null));
        }

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