namespace GenerateParentheses;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        GenerateParenthesis(n, n, "", result);
        return result;
    }

    private static void GenerateParenthesis(int i1, int i2, string empty, List<string> result)
    {
        if (i1 == 0 && i2 == 0)
        {
            result.Add(empty);
            return;
        }

        if (i1 > 0)
        {
            GenerateParenthesis(i1 - 1, i2, $"{empty}(", result);
        }

        if (i2 > i1)
        {
            GenerateParenthesis(i1, i2 - 1, $"{empty})", result);
        }
    }
}