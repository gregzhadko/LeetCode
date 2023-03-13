namespace RotateImage;

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        var length = matrix.Length;
        
        Array.Reverse(matrix);
        for(var i = 0; i < length; i++)
        {
            for(var j = i + 1; j < length; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }
    }
}