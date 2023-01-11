using NUnit.Framework;

namespace SwapNodesInPairs;

public class Tests
{
    [Test]
    public void Test1()
    {
        var head = new ListNode(1, new(2, new(3, new(4))));
        var result = new Solution().SwapPairs(head);
        Assert.AreEqual(2, result.val);
        Assert.AreEqual(1, result.next.val);
        Assert.AreEqual(4, result.next.next.val);
        Assert.AreEqual(3, result.next.next.next.val);
    }
    
    [Test]
    public void Test2()
    {
        var head = new ListNode(1, new(2, new(3, new(4, new(5)))));
        var result = new Solution().SwapPairs(head);
        Assert.AreEqual(2, result.val);
        Assert.AreEqual(1, result.next.val);
        Assert.AreEqual(4, result.next.next.val);
        Assert.AreEqual(3, result.next.next.next.val);
        Assert.AreEqual(5, result.next.next.next.next.val);
    }
    
    [Test]
    public void Test3()
    {
        var head = new ListNode(1, new(2, new(3, new(4, new(5, new(6))))));
        var result = new Solution().SwapPairs(head);
        Assert.AreEqual(2, result.val);
        Assert.AreEqual(1, result.next.val);
        Assert.AreEqual(4, result.next.next.val);
        Assert.AreEqual(3, result.next.next.next.val);
        Assert.AreEqual(6, result.next.next.next.next.val);
        Assert.AreEqual(5, result.next.next.next.next.next.val);
    }
    
    [Test]
    public void Test4()
    {
        var head = new ListNode(1, new(2));
        var result = new Solution().SwapPairs(head);
        Assert.AreEqual(2, result.val);
        Assert.AreEqual(1, result.next.val);
    }
}