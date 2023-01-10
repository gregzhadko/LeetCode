using NUnit.Framework;

namespace PlusOne;

public class Tests
{
    [Test]
    public void Test1()
    {
        var input = new[] { 1, 2, 3 };
        var expected = new[] { 1, 2, 4 };
        var actual = new Solution().PlusOne(input);
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void Test2()
    {
        var input = new[] { 4, 3, 2, 1 };
        var expected = new[] { 4, 3, 2, 2 };
        var actual = new Solution().PlusOne(input);
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void Test3()
    {
        var input = new[] { 0 };
        var expected = new[] { 1 };
        var actual = new Solution().PlusOne(input);
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void Test4()
    {
        var input = new[] { 9 };
        var expected = new[] { 1, 0 };
        var actual = new Solution().PlusOne(input);
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void Test5()
    {
        var input = new[] { 9, 9 };
        var expected = new[] { 1, 0, 0 };
        var actual = new Solution().PlusOne(input);
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void Test6()
    {
        var input = new[] { 9, 9, 9 };
        var expected = new[] { 1, 0, 0, 0 };
        var actual = new Solution().PlusOne(input);
        Assert.AreEqual(expected, actual);
    }
}