namespace RecursionI.SwapNodesInPairs
{
    public class Solution
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

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}