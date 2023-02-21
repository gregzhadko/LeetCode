namespace ReverseNodesInKGroup;

public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (k == 1)
        {
            return head;
        }
        
        var lenght = 1;
        var temp = head;
        while(temp.next != null)
        {
            lenght++;
            temp = temp.next;
        }

        temp = head;
        var count = 0;
        while (temp != null && lenght - count >= k)
        {
            temp = Reverse(temp, k).next;
            count += k;
        }
        
        return head;
    }

    private ListNode Reverse(ListNode head, int k)
    {
        return head;
    }
}