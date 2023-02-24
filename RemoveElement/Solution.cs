namespace RemoveElement;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var i = 0;
        var j = 0;
        while (j < nums.Length)
        {
            if (nums[j] == val)
            {
                j++;
                continue;
            }

            nums[i] = nums[j];
            j++;
            i++;
        }

        return i;
    }
}