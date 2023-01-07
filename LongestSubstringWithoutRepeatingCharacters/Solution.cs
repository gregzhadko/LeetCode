namespace LongestSubstringWithoutRepeatingCharacters;

public class Solution {
    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0)
        {
            return 0;
        }
        
        var result = 1;
        
        for (var i = 0; i < s.Length; i++)
        {
            var hashSet = new HashSet<char>();
            for (var j = i; j < s.Length; j++)
            {
                if (!hashSet.Contains(s[j]))
                {
                    hashSet.Add(s[j]);
                    continue;
                }

                if (result < hashSet.Count)
                {
                    result = hashSet.Count;
                }

                break;
            }
            
            if(result < hashSet.Count)
            {
                result = hashSet.Count;
            }
        }
        
        return result;
    }
}