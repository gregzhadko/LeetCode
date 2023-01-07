using NUnit.Framework;

namespace RomanToInteger;

public class Tests
{
    [Test]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.RomanToInt("III");
        Assert.AreEqual(3, result);
    }
    
    [Test]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.RomanToInt("IV");
        Assert.AreEqual(4, result);
    }
    
    [Test]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.RomanToInt("IX");
        Assert.AreEqual(9, result);
    }
    
    [Test]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.RomanToInt("LVIII");
        Assert.AreEqual(58, result);
    }
    
    [Test]
    public void Test5()
    {
        var solution = new Solution();
        var result = solution.RomanToInt("MCMXCIV");
        Assert.AreEqual(1994, result);
    }
    
    [Test]
    public void Test6()
    {
        var solution = new Solution();
        var result = solution.RomanToInt("MCMXCIV");
        Assert.AreEqual(1994, result);
    }
    
    [Test]
    public void Test7()
    {
        var solution = new Solution();
        var result = solution.RomanToInt("MCMXCIV");
        Assert.AreEqual(1994, result);
    }
    
}