using NUnit.Framework;

namespace ThreeSumClosest;

public class Tests
{
    [Test]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.ThreeSumClosest(new[] { -1, 2, 1, -4 }, 1);
        Assert.AreEqual(2, result);
    }
    
    [Test]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.ThreeSumClosest(new[] { 0, 2, 1, -3 }, 1);
        Assert.AreEqual(0, result);
    }
    
    [Test]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.ThreeSumClosest(new[] { 1, 1, 1, 0 }, -100);
        Assert.AreEqual(2, result);
    }
    
    [Test]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.ThreeSumClosest(new[] { 0, 0, 0 }, 1);
        Assert.AreEqual(0, result);
    }
}