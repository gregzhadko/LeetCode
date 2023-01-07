using NUnit.Framework;

namespace ThreeSum;

public class Tests
{
    [Test]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
        Assert.AreEqual(2, result.Count);
    }

    [Test]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.ThreeSum(new[] { 0, 0, 0, 0 });
        Assert.AreEqual(1, result.Count);
    }

    [Test]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.ThreeSum(new[] { 0, 0, 0 });
        Assert.AreEqual(1, result.Count);
    }

    [Test]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.ThreeSum(new[] { 0, 0, 0, 1 });
        Assert.AreEqual(1, result.Count);
    }

    [Test]
    public void Test5()
    {
        var solution = new Solution();
        var result = solution.ThreeSum(new[] { 1, 2, -2, -1 });
        Assert.AreEqual(0, result.Count);
    }
}