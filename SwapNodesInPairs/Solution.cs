namespace SwapNodesInPairs;

public class Solution
{
    public ListNode? SwapPairs(ListNode? head)
    {
        if (head?.next == null)
        {
            return head;
        }
        
        var current = head;
        var newHead = current.next;
        ListNode? prevNode = null;
        while (current != null && current.next != null)
        {
            var next = current.next;
            current.next = current.next.next;
            next.next = current;
            
            if (prevNode != null)
            {
                prevNode.next = next;
            }

            prevNode = current;
            current = current.next;
        }
        return newHead;
    }
}