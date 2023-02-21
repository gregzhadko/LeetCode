using NUnit.Framework;

namespace MergeTwoSortedLists;

public class Tests
{
    [Test]
    public void Test()
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var solution = new Solution();
        var merged = solution.MergeTwoLists(list1, list2);
        var mergedArray = merged.ToList();
        var expected = new List<int> { 1, 1, 2, 3, 4, 4 };
        
        CollectionAssert.AreEqual(expected, mergedArray);
    }
    
    
}