using NUnit.Framework;

namespace ReverseNodesInKGroup;

public class Tests
{
    [Test]
    public void Test1()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var result = new Solution().ReverseKGroup(head, 2);
        Assert.AreEqual(2, result.val);
        Assert.AreEqual(1, result.next.val);
        Assert.AreEqual(4, result.next.next.val);
        Assert.AreEqual(3, result.next.next.next.val);
        Assert.AreEqual(5, result.next.next.next.next.val);
    }
    
    [Test]
    public void Test2()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var result = new Solution().ReverseKGroup(head, 3);
        Assert.AreEqual(3, result.val);
        Assert.AreEqual(2, result.next.val);
        Assert.AreEqual(1, result.next.next.val);
        Assert.AreEqual(4, result.next.next.next.val);
        Assert.AreEqual(5, result.next.next.next.next.val);
    }
    
    [Test]
    public void Test3()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var result = new Solution().ReverseKGroup(head, 1);
        Assert.AreEqual(1, result.val);
        Assert.AreEqual(2, result.next.val);
        Assert.AreEqual(3, result.next.next.val);
        Assert.AreEqual(4, result.next.next.next.val);
        Assert.AreEqual(5, result.next.next.next.next.val);
    }
    
    [Test]
    public void Test4()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var result = new Solution().ReverseKGroup(head, 5);
        Assert.AreEqual(5, result.val);
        Assert.AreEqual(4, result.next.val);
        Assert.AreEqual(3, result.next.next.val);
        Assert.AreEqual(2, result.next.next.next.val);
        Assert.AreEqual(1, result.next.next.next.next.val);
    }
}