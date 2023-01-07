using System.Text;

namespace IntegerToRoman;

public class Solution
{
    public string IntToRoman(int num)
    {
        var units = num % 10;
        var tens = (num / 10) % 10;
        var hundreds = (num / 100) % 10;
        var thousands = (num / 1000) % 10;

        var result = new StringBuilder();
        if (thousands > 0)
        {
            result.Append(new string('M', thousands));
        }

        if (hundreds > 0)
        {
            result.Append(GetRomanDigit(hundreds, 'C', 'D', 'M'));
        }

        if (tens > 0)
        {
            result.Append(GetRomanDigit(tens, 'X', 'L', 'C'));
        }

        if (units > 0)
        {
            result.Append(GetRomanDigit(units, 'I', 'V', 'X'));
        }

        return result.ToString();
    }

    private string GetRomanDigit(int number, char lower, char middle, char upper)
    {
        return number switch
        {
            < 4 => new(lower, number),
            4 => $"{lower}{middle}",
            5 => middle.ToString(),
            > 5 and < 9 => $"{middle}{new(lower, number - 5)}",
            9 => $"{lower}{upper}",
            _ => throw new ArgumentOutOfRangeException(nameof(number))
        };
    }
}