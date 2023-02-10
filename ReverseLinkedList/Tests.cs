using NUnit.Framework;

namespace ReverseLinkedList;

public class Tests
{
    [Test]
    public void ReverseLinkedList()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var result = new Solution().ReverseList(head);
        Assert.AreEqual(5, result.val);
        Assert.AreEqual(4, result.next.val);
        Assert.AreEqual(3, result.next.next.val);
        Assert.AreEqual(2, result.next.next.next.val);
        Assert.AreEqual(1, result.next.next.next.next.val);
    }
    
    [Test]
    public void ReverseLinkedList2()
    {
        var head = new ListNode(1, new ListNode(2));
        var result = new Solution().ReverseList(head);
        Assert.AreEqual(2, result.val);
        Assert.AreEqual(1, result.next.val);
    }
    
    [Test]
    public void ReverseLinkedList3()
    {
        var head = new ListNode(1);
        var result = new Solution().ReverseList(head);
        Assert.AreEqual(1, result.val);
    }
}