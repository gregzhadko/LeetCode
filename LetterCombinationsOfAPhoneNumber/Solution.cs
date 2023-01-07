using System.Text;

namespace LetterCombinationsOfAPhoneNumber;

public class Solution
{
    private static readonly string[] Keys = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();
        if (digits.Length == 0)
        {
            return result;
        }

        var sb = new StringBuilder();
        result = LetterCombinations(digits, 0, new() { sb });
        return result;
    }

    private List<string> LetterCombinations(string digits, int index, List<StringBuilder> stringBuilders)
    {
        if (index == digits.Length)
        {
            return stringBuilders.Select(sb => sb.ToString()).ToList();
        }

        var keyIndex = digits[index] - '0';

        var newStringBuilders = new List<StringBuilder>();
        foreach (var key in Keys[keyIndex])
        {
            foreach (var sb in stringBuilders)
            {
                var newSb = new StringBuilder(sb.Length + 1);
                newSb.Append(sb);
                newSb.Append(key);
                newStringBuilders.Add(newSb);
            }
        }

        return LetterCombinations(digits, index + 1, newStringBuilders);
    }
}