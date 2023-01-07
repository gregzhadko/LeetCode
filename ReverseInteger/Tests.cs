using Xunit;

namespace ReverseInteger;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        Assert.Equal(321, solution.Reverse(123));
    }
    
    [Fact]
    public void Test2()
    {
        var solution = new Solution();
        Assert.Equal(-321, solution.Reverse(-123));
    }
    
    [Fact]
    public void Test3()
    {
        var solution = new Solution();
        Assert.Equal(21, solution.Reverse(120));
    }
    
    [Fact]
    public void Test4()
    {
        var solution = new Solution();
        Assert.Equal(0, solution.Reverse(0));
    }
    
    [Fact]
    public void Test5()
    {
        var solution = new Solution();
        Assert.Equal(0, solution.Reverse(1534236469));
    }
    
    [Fact]
    public void Test6()
    {
        var solution = new Solution();
        Assert.Equal(0, solution.Reverse(-2147483648));
    }
    
    [Fact]
    public void Test7()
    {
        var solution = new Solution();
        Assert.Equal(0, solution.Reverse(2147483647));
    }
    
    [Fact]
    public void Test8()
    {
        var solution = new Solution();
        Assert.Equal(0, solution.Reverse(1463847412));
    }
}