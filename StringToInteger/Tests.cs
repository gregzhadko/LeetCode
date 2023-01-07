using NUnit.Framework;

namespace StringToInteger;

public class Tests
{
    [Test]
    public void Test1()
    {
        var result = Solution.MyAtoi("42");
        Assert.AreEqual(42, result);
    }

    [Test]
    public void Test2()
    {
        var result = Solution.MyAtoi("   -42");
        Assert.AreEqual(-42, result);
    }

    [Test]
    public void Test3()
    {
        var result = Solution.MyAtoi("4193 with words");
        Assert.AreEqual(4193, result);
    }

    [Test]
    public void Test4()
    {
        var result = Solution.MyAtoi("words and 987");
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test5()
    {
        var result = Solution.MyAtoi("9999999999999999");
        Assert.AreEqual(int.MaxValue, result);
    }
    
    [Test]
    public void Test6()
    {
        var result = Solution.MyAtoi("-9999999999999999");
        Assert.AreEqual(int.MinValue, result);
    }
    
    [Test]
    public void Test7()
    {
        var result = Solution.MyAtoi("-91283472332");
        Assert.AreEqual(-2147483648, result);
    }

    [Test]
    public void Test8()
    {
        var result = Solution.MyAtoi("  -0012a42");
        Assert.AreEqual(-12, result);
    }
    
    [Test]
    public void Test9()
    {
        var result = Solution.MyAtoi("2147483648");
        Assert.AreEqual(2147483647, result);
    }
    
    [Test]
    public void Test10()
    {
        var result = Solution.MyAtoi("2147483646");
        Assert.AreEqual(2147483646, result);
    }
    
    [Test]
    public void Test11()
    {
        var result = Solution.MyAtoi("21474836460");
        Assert.AreEqual(2147483647, result);
    }
    
    [Test]
    public void Test12()
    {
        var result = Solution.MyAtoi(" -88827   5655  U");
        Assert.AreEqual(-88827, result);
    }
}