using Xunit;

namespace LongestPalindromicSubstring;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var result = Solution.LongestPalindrome("babad");
        Assert.Equal("bab", result);
    }
    
    [Fact]
    public void Test2()
    {
        var result = Solution.LongestPalindrome("cbbd");
        Assert.Equal("bb", result);
    }
    
    [Fact]
    public void Test3()
    {
        var result = Solution.LongestPalindrome("a");
        Assert.Equal("a", result);
    }
    
    [Fact]
    public void Test4()
    {
        var result = Solution.LongestPalindrome("ac");
        Assert.Equal("a", result);
    }
    
    [Fact]
    public void Test5()
    {
        var result = Solution.LongestPalindrome("ccc");
        Assert.Equal("ccc", result);
    }
    
    [Fact]
    public void Test6()
    {
        var result = Solution.LongestPalindrome("aaaa");
        Assert.Equal("aaaa", result);
    }
   
}