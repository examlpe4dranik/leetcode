namespace RecursionI.SwapNodesInPairs
{
    public class SolutionSwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode node)
        {
            if (node == null || node.next == null)
            {
                return node;
            }

            var tmp = node.val;
            node.val = node.next.val;
            node.next.val = tmp;

            SwapPairs(node.next.next);

            return node;
        }
    }
}