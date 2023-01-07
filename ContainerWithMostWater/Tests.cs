using NUnit.Framework;

namespace ContainerWithMostWater;

public class Tests
{
    [Test]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        Assert.AreEqual(49, result);
    }
    
    [Test]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.MaxArea(new[] { 1, 1 });
        Assert.AreEqual(1, result);
    }
    
    [Test]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.MaxArea(new[] { 4, 3, 2, 1, 4 });
        Assert.AreEqual(16, result);
    }
    
    [Test]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.MaxArea(new[] { 1, 2, 1 });
        Assert.AreEqual(2, result);
    }
    
    [Test]
    public void Test5()
    {
        var solution = new Solution();
        var result = solution.MaxArea(new[] { 1, 2, 4, 3 });
        Assert.AreEqual(4, result);
    }
    
    [Test]
    public void Test6()
    {
        var solution = new Solution();
        var result = solution.MaxArea(new[] { 1, 3, 2, 5, 25, 24, 5 });
        Assert.AreEqual(24, result);
    }
    
    [Test]
    public void Test7()
    {
        var solution = new Solution();
        var result = solution.MaxArea(new[] { 1, 2, 4, 3 });
        Assert.AreEqual(4, result);
    }
    
    [Test]
    public void Test8()
    {
        var solution = new Solution();
        var result = solution.MaxArea(new[] { 1, 3, 2, 5, 25, 24, 5 });
        Assert.AreEqual(24, result);
    }
}