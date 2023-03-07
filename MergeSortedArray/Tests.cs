using NUnit.Framework;

namespace MergeSortedArray;

public class Tests
{
    [Test]
    public void Test1()
    {
        var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
        var nums2 = new[] { 2, 5, 6 };
        new Solution().Merge(nums1, 3, nums2, 3);
        Assert.AreEqual(new[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }

    [Test]
    public void Test2()
    {
        var nums1 = new[] { 1 };
        var nums2 = new[] { 0 };
        new Solution().Merge(nums1, 1, nums2, 0);
        Assert.AreEqual(new[] { 1 }, nums1);
    }

    [Test]
    public void Test3()
    {
        var nums1 = new[] { 0 };
        var nums2 = new[] { 1 };
        new Solution().Merge(nums1, 0, nums2, 1);
        Assert.AreEqual(new[] { 1 }, nums1);
    }
}