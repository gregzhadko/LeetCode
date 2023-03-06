using NUnit.Framework;

namespace Candy;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(5, new Solution().Candy(new[] {1, 0, 2}));
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(4, new Solution().Candy(new[] {1, 2, 2}));
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(11, new Solution().Candy(new[] {1, 3, 4, 5, 2}));
    }
    
    
}