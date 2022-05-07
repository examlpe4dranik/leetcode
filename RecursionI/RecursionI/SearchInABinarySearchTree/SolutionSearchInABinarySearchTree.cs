namespace RecursionI.SearchInABinarySearchTree
{
    public class SolutionSearchInABinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            TreeNode result = null;

            if (root.val == val)
            {
                return root;
            }
            else
            {
                if (root.left != null)
                {
                    result = SearchBST(root.left, val);
                }

                if (result != null)
                {
                    return result;
                }

                if (root.right != null)
                {
                    result = SearchBST(root.right, val);
                }
            }

            return result;
        }
    }
}