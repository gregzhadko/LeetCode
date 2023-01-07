using Xunit;

namespace LongestSubstringWithoutRepeatingCharacters;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var s = "abcabcbb";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void Test2()
    {
        var s = "bbbbb";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Test3()
    {
        var s = "pwwkew";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void Test4()
    {
        var s = "";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void Test5()
    {
        var s = " ";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Test6()
    {
        var s = "dvdf";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void Test7()
    {
        var s = "abba";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void Test8()
    {
        var s = "tmmzuxt";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Test9()
    {
        var s = "ohvhjdml";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(6, result);
    }
    
    [Fact]
    public void Test10()
    {
        var s = "anviaj";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Test11()
    {
        var s = "au";
        var result = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(2, result);
    }

}