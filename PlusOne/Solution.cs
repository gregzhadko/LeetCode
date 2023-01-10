namespace PlusOne;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var currentIndex = digits.Length - 1;
        while (currentIndex >= 0)
        {
            if (digits[currentIndex] != 9)
            {
                digits[currentIndex]++;
                return digits;
            }
            
            digits[currentIndex] = 0;
            currentIndex--;
        }

        if (currentIndex == -1)
        {
            var newDigits = new int[digits.Length + 1];
            digits.CopyTo(newDigits, 1);
            newDigits[0] = 1;
            return newDigits;
        }

        return digits;
    }
}