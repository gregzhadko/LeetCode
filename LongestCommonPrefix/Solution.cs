namespace LongestCommonPrefix;

public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        var index = 0;
        while (index < strs[0].Length)
        {
            var symbol = strs[0][index];
            if (strs.Any(s => index >= s.Length || s[index] != symbol))
            {
                break;
            }

            index++;
        }
    
        return strs[0][..index];
    }
}