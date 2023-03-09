namespace ValidSudoku;

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var rowsHashSets = Enumerable.Range(0, 9).Select(_ => new HashSet<int>()).ToArray();
        var columnsHashSets = Enumerable.Range(0, 9).Select(_ => new HashSet<int>()).ToArray();
        var boxesHashSets = Enumerable.Range(0, 9).Select(_ => new HashSet<int>()).ToArray();

        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                if(board[i][j] == '.')
                {
                    continue;
                }
                var value = board[i][j] - '0';
                if (!CheckValue(value, rowsHashSets[i]) 
                    || !CheckValue(value, columnsHashSets[j]) 
                    || !CheckValue(value, boxesHashSets[(i / 3) * 3 + j / 3]))
                {
                    return false;
                }
            }
        }

        return true;
    }

    private static bool CheckValue(int value, ISet<int> hashSet)
    {
        if(value is < 0 or > 9 || hashSet.Contains(value))
        {
            return false;
        }

        if (value != 0)
        {
            hashSet.Add(value);
        }

        return true;
    }
}