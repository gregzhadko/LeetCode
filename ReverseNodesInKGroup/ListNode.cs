using System.Text;

namespace ReverseNodesInKGroup;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
    
    public override string ToString()
    {
        var temp = this;
        var sb = new StringBuilder();
        while (temp != null)
        {
            sb.Append(temp.val + "; ");
            temp = temp.next;
        }

        return sb.ToString();
    }
}