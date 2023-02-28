namespace DivideTwoIntegers;

public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        if (divisor == 1)
        {
            return dividend;
        }

        if (dividend == 0)
        {
            return 0;
        }

        if (dividend == divisor)
        {
            return 1;
        }

        var isPositive = (divisor > 0 && dividend > 0) || (divisor < 0 && dividend < 0);

        if (divisor > 0)
        {
            divisor = ~divisor + 1;
        }

        if (dividend > 0)
        {
            dividend = ~dividend + 1;
        }


        var result = 0;
        while (dividend <= divisor)
        {
            var power = -1;
            var value = divisor;
            while (value >= int.MinValue / 2 && value + value >= dividend)
            {
                power += power;
                value += value;
            }

            result += power;
            dividend -= value;
        }

        return isPositive ? ~result + 1 : result;
    }
}