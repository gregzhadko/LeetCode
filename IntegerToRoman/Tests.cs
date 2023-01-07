using NUnit.Framework;

namespace IntegerToRoman;

public class Tests
{
    [Test]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.IntToRoman(3);
        Assert.AreEqual("III", result);
    }
    
    [Test]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.IntToRoman(4);
        Assert.AreEqual("IV", result);
    }
    
    [Test]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.IntToRoman(9);
        Assert.AreEqual("IX", result);
    }
    
    [Test]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.IntToRoman(58);
        Assert.AreEqual("LVIII", result);
    }
    
    [Test]
    public void Test5()
    {
        var solution = new Solution();
        var result = solution.IntToRoman(1994);
        Assert.AreEqual("MCMXCIV", result);
    }
    
    [Test]
    public void Test6()
    {
        var solution = new Solution();
        var result = solution.IntToRoman(3999);
        Assert.AreEqual("MMMCMXCIX", result);
    }
    
}