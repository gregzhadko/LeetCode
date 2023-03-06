namespace Candy;

public class Solution
{
    public int Candy(int[] ratings)
    {
        var result = new int[ratings.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = 1;
        }

        for (var i = 1; i < result.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                result[i] = result[i - 1] + 1;
            }
        }

        for (var i = result.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1] && result[i] <= result[i + 1])
            {
                result[i] = result[i + 1] + 1;
            }
        }

        return result.Sum();
    }
}