using NUnit.Framework;

namespace GenerateParentheses;

public class Tests
{
    [Test]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.GenerateParenthesis(3);
        Assert.AreEqual(5, result.Count);
    }
    
    [Test]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.GenerateParenthesis(1);
        Assert.AreEqual(1, result.Count);
    }
    
    [Test]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.GenerateParenthesis(2);
        Assert.AreEqual(2, result.Count);
    }
    
    [Test]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.GenerateParenthesis(4);
        Assert.AreEqual(14, result.Count);
    }
}