using System.Text;

namespace ZigzagConversion;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }
        var result = new List<char>[numRows];
        for (var x = 0; x < numRows; x++)
        {
            result[x] = new(s.Length/numRows + 1);
        }

        var forwardMove = false;
        var row = 0;
        for (var i = 0; i < s.Length; i++)
        {
            result[row].Add(s[i]);
            
            if (row == numRows - 1 || row == 0)
            {
                forwardMove = !forwardMove;
            }

            if (forwardMove)
            {
                row++;
            }
            else
            {
                row--;
            }
        }

        var stringBuilder = new StringBuilder(s.Length);
        foreach (var list in result)
        {
            foreach (var c in list)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString();
    }
}