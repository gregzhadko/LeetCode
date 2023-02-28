namespace LengthOfLastWord;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var i = s.Length - 1;
        while(i >= 0 && s[i] == ' ')
        {
            i--;
        }

        var result = 0;
        while(i >= 0 && s[i] != ' ')
        {
            result++;
            i--;
        }

        return result;
    }
}