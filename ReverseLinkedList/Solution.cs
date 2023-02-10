namespace ReverseLinkedList;

public class Solution
{
    public ListNode? ReverseList(ListNode? head)
    {
        if (head?.next == null)
        {
            return head;
        }

        var current = head;
        var next = head.next;
        ListNode? previous = null;

        while (next != null)
        {
            current.next = previous;
            previous = current;
            current = next;
            next = next.next;
        }

        current.next = previous;
        return current;

    }
}