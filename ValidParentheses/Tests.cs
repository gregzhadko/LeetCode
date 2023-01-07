using NUnit.Framework;

namespace ValidParentheses;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.IsTrue(new Solution().IsValid("()"));
    }
    
    [Test]
    public void Test2()
    {
        Assert.IsTrue(new Solution().IsValid("()[]{}"));
    }
    
    [Test]
    public void Test3()
    {
        Assert.IsFalse(new Solution().IsValid("(]"));
    }
    
    [Test]
    public void Test4()
    {
        Assert.IsFalse(new Solution().IsValid("([)]"));
    }
    
    [Test]
    public void Test5()
    {
        Assert.IsTrue(new Solution().IsValid("{[]}"));
    }
    
    [Test]
    public void Test6()
    {
        Assert.IsFalse(new Solution().IsValid("]"));
    }
    
    [Test]
    public void Test7()
    {
        Assert.IsFalse(new Solution().IsValid("(("));
    }
}