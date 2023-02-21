namespace MergeTwoSortedLists;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public List<int> ToList()
    {
        var list = new List<int>();
        var current = this;
        while(current != null)
        {
            list.Add(current.val);
            current = current.next;
        }

        return list;
    }
}