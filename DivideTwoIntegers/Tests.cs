using NUnit.Framework;

namespace DivideTwoIntegers;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(3, new Solution().Divide(10, 3));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual(5, new Solution().Divide(10, 2));
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(1, new Solution().Divide(10, 10));
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(0, new Solution().Divide(10, 100));
    }
    
    [Test]
    public void Test5()
    {
        Assert.AreEqual(-2, new Solution().Divide(7, -3));
    }
    
    [Test]
    public void Test6()
    {
        Assert.AreEqual(2147483647, new Solution().Divide(-2147483648, -1));
    }
    
    [Test]
    public void Test7()
    {
        Assert.AreEqual(2147483647, new Solution().Divide(2147483647, 1));
    }
    
    [Test]
    public void Test8()
    {
        Assert.AreEqual(1073741823, new Solution().Divide(2147483647, 2));
    }
    
    [Test]
    public void Test9()
    {
        Assert.AreEqual(-1073741824, new Solution().Divide(-2147483648, 2));
    }
}