using NUnit.Framework;

namespace RemoveElement;

public class Tests
{
    [Test]
    public void Test1()
    {
        var nums = new[] { 3, 2, 2, 3 };
        var result = new Solution().RemoveElement(nums, 3);
        Assert.AreEqual(2, result);
        Assert.AreEqual(2, nums[0]);
        Assert.AreEqual(2, nums[1]);
    }
    
    [Test]
    public void Test2()
    {
        var nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        var result = new Solution().RemoveElement(nums, 2);
        Assert.AreEqual(5, result);
        Assert.AreEqual(0, nums[0]);
        Assert.AreEqual(1, nums[1]);
        Assert.AreEqual(3, nums[2]);
        Assert.AreEqual(0, nums[3]);
        Assert.AreEqual(4, nums[4]);
    }
}