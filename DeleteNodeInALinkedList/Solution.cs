namespace DeleteNodeInALinkedList;

public class Solution
{
    public void Delete(Node node)
    {
        (node.Value, node.Next) = (node.Next.Value, node.Next.Next);
    }
}