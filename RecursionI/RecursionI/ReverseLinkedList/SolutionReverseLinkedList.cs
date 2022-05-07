namespace RecursionI.ReverseLinkedList
{
    internal class SolutionReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head != null && head.next != null)
            {
                return ReverseList(head, null);
            }
            else
            {
                return head;
            }
        }

        private ListNode ReverseList(ListNode node, ListNode prewNode)
        {
            if (node != null)
            {
                var newNode = new ListNode { val = node.val, next = prewNode };
                return ReverseList(node.next, newNode);
            }
            else
            {
                return prewNode;
            }
        }
    }
}