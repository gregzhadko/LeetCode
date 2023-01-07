using Xunit;

namespace ZigzagConversion;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.Convert("PAYPALISHIRING", 3);
        Assert.Equal("PAHNAPLSIIGYIR", result);
    }
    
    [Fact]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.Convert("PAYPALISHIRING", 4);
        Assert.Equal("PINALSIGYAHRPI", result);
    }
    
    [Fact]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.Convert("A", 1);
        Assert.Equal("A", result);
    }
    
    [Fact]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.Convert("AB", 1);
        Assert.Equal("AB", result);
    }
    
    [Fact]
    public void Test5()
    {
        var solution = new Solution();
        var result = solution.Convert("AB", 2);
        Assert.Equal("AB", result);
    }
    
    [Fact]
    public void Test6()
    {
        var solution = new Solution();
        var result = solution.Convert("ABC", 2);
        Assert.Equal("ACB", result);
    }
}