namespace GenerateMatrix;

public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        var result = new int[n][];
        for (var i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        var x = -1;
        var y = 0;
        var direction = Direction.Right;
        var number = 1;
        while (number <= n*n)
        {
            switch (direction)
            {
                case Direction.Right:
                {
                    x++;
                    if (x == n - 1 || result[y][x + 1] != 0)
                    {
                        direction = Direction.Down;
                    }

                    break;
                }
                case Direction.Down:
                {
                    y++;
                    if (y == n - 1 || result[y + 1][x] != 0)
                    {
                        direction = Direction.Left;
                    }

                    break;
                }
                case Direction.Left:
                {
                    x--;
                    if (x == 0 || result[y][x - 1] != 0)
                    {
                        direction = Direction.Up;
                    }

                    break;
                }
                case Direction.Up:
                {
                    y--;
                    if (y == 0 || result[y - 1][x] != 0)
                    {
                        direction = Direction.Right;
                    }

                    break;
                }
            }

            result[y][x] = number;
            number++;
        }

        return result;
    }

    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
}