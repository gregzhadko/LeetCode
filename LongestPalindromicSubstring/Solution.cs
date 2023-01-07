namespace LongestPalindromicSubstring;

public static class Solution {
    public static string LongestPalindrome(string s)
    {
        Span<char>
        var chars = s.ToCharArray();

        var result = chars[0].ToString();
        
        for (var i = 0; i < chars.Length; i++)
        {
            for (var j = chars.Length - 1; j > i + result.Length - 1; j--)
            {
                if(IsPalindrome(chars,i, j) && j - i + 1 > result.Length)
                {
                    result = new(chars, i, j - i + 1);
                }
            }
        }

        return result;
    }

    private static bool IsPalindrome(char[] chars, int start, int end)
    {
        var left = start;
        var right = end;

        while (left <= right)
        {
            if (chars[left] != chars[right])
            {
                return false;
            }
            
            left++;
            right--;
        }

        return true;
    }
}