using NUnit.Framework;

namespace LengthOfLastWord;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(5, new Solution().LengthOfLastWord("Hello World"));
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(1, new Solution().LengthOfLastWord("a "));
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(4, new Solution().LengthOfLastWord("   fly me   to   the moon  "));
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(6, new Solution().LengthOfLastWord("luffy is still joyboy"));
    }
}