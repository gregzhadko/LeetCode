using NUnit.Framework;

namespace SearchInsertPosition;

public class Tests
{
    [Test]
    public void Test1()
    {
        var nums = new[] { 1, 3, 5, 6 };
        var result = new Solution().SearchInsert(nums, 5);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Test2()
    {
        var nums = new[] { 1, 3, 5, 6 };
        var result = new Solution().SearchInsert(nums, 2);
        Assert.AreEqual(1, result);
    }

    [Test]
    public void Test3()
    {
        var nums = new[] { 1, 3, 5, 6 };
        var result = new Solution().SearchInsert(nums, 7);
        Assert.AreEqual(4, result);
    }

    [Test]
    public void Test4()
    {
        var nums = new[] { 1, 3, 5, 6 };
        var result = new Solution().SearchInsert(nums, 0);
        Assert.AreEqual(0, result);
    }
}