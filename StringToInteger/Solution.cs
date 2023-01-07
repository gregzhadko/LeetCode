namespace StringToInteger;

public class Solution
{
    public static int MyAtoi(string s)
    {
        var digits = new HashSet<char>() {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        var result = 0;

        var i = 0;
        var signSelected = false;
        var digitStarted = false;
        var minus = false;
        while (i < s.Length)
        {
            var index = i++;
            if (s[index] == ' ')
            {
                if (digitStarted)
                {
                    break;
                }

                if (signSelected)
                {
                    return 0;
                }
                
                continue;
            }

            if (!signSelected)
            {
                if (digits.Contains(s[index]))
                {
                    signSelected = true;
                }
                else
                {
                    switch (s[index])
                    {
                        case '-':
                            signSelected = true;
                            minus = true;
                            break;
                        case '+':
                            signSelected = true;
                            break;
                        default:
                            return 0;
                    }

                    continue;
                }
            }

            if (!digits.Contains(s[index]))
            {
                break;
            }

            digitStarted = true;
            var digit = (s[index] - '0');
            if(!minus && (result > int.MaxValue/10 || result == int.MaxValue/10 && digit > 7))
            {
                return int.MaxValue;
            }

            if (minus && (-result < int.MinValue/10 || -result == int.MinValue/10 && digit > 8))
            {
                return int.MinValue;
            }

            result = result * 10 + digit;
        }
        
        return minus ? -result : result;
    }
}