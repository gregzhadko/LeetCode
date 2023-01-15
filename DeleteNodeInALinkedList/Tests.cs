using NUnit.Framework;

namespace DeleteNodeInALinkedList;

public class Tests
{
    [Test]
    public void Test1()
    {
        var head = new Node(1, new (2, new (3, new (4, new (5)))));
        new Solution().Delete(head.Next!.Next);
        Assert.AreEqual(1, head.Value);
        Assert.AreEqual(2, head.Next.Value);
        Assert.AreEqual(4, head.Next.Next.Value);
        Assert.AreEqual(5, head.Next.Next.Next.Value);
        
    }
}