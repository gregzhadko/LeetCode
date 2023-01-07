using NUnit.Framework;

namespace RegularExpressionMatching;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.IsFalse(Solution.IsMatch("aa", "a"));
    }
    
    [Test]
    public void Test2()
    {
        Assert.IsTrue(Solution.IsMatch("aa", "a*"));
    }
    
    [Test]
    public void Test3()
    {
        Assert.IsTrue(Solution.IsMatch("ab", ".*"));
    }
    
    [Test]
    public void Test4()
    {
        Assert.IsTrue(Solution.IsMatch("aab", "c*a*b"));
    }
    
    [Test]
    public void Test5()
    {
        Assert.IsFalse(Solution.IsMatch("mississippi", "mis*is*p*."));
    }
    
    [Test]
    public void Test6()
    {
        Assert.IsTrue(Solution.IsMatch("aaa", "a*a"));
    }
    
    [Test]
    public void Test7()
    {
        Assert.IsTrue(Solution.IsMatch("aaa", "ab*a*c*a"));
    }
}