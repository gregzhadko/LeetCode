using NUnit.Framework;

namespace FourSum;

public class Tests
{
    [Test]
    public void Test1()
    {
        var nums = new[] { 1, 0, -1, 0, -2, 2 };
        var result = new Solution().FourSum(nums, 0);
        Assert.AreEqual(3, result.Count);
        Assert.AreEqual(-2, result[0][0]);
        Assert.AreEqual(-1, result[0][1]);
        Assert.AreEqual(1, result[0][2]);
        Assert.AreEqual(2, result[0][3]);
        Assert.AreEqual(-2, result[1][0]);
        Assert.AreEqual(0, result[1][1]);
        Assert.AreEqual(0, result[1][2]);
        Assert.AreEqual(2, result[1][3]);
        Assert.AreEqual(-1, result[2][0]);
        Assert.AreEqual(0, result[2][1]);
        Assert.AreEqual(0, result[2][2]);
        Assert.AreEqual(1, result[2][3]);
    }
}