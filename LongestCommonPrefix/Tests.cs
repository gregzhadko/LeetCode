using NUnit.Framework;

namespace LongestCommonPrefix;

public class Tests
{
    [Test]
    public void Test1()
    {
        var input = new[] {"flower", "flow", "flight"};
        var actual = new Solution().LongestCommonPrefix(input);
        Assert.AreEqual("fl", actual);
    }
    
    [Test]
    public void Test2()
    {
        var input = new[] {"dog", "racecar", "car"};
        var actual = new Solution().LongestCommonPrefix(input);
        Assert.AreEqual("", actual);
    }
    
    [Test]
    public void Test3()
    {
        var input = new[] {"dog", "dog", "dog"};
        var actual = new Solution().LongestCommonPrefix(input);
        Assert.AreEqual("dog", actual);
    }
    
    [Test]
    public void Test4()
    {
        var input = new[] {"dog", "dog", "dog", "dog"};
        var actual = new Solution().LongestCommonPrefix(input);
        Assert.AreEqual("dog", actual);
    }
    
    [Test]
    public void Test5()
    {
        var input = new[] {"dog", "dog", "dog", "dog", "dog"};
        var actual = new Solution().LongestCommonPrefix(input);
        Assert.AreEqual("dog", actual);
    }
}