namespace SearchInsertPosition;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var middle = (left + right) / 2;
            var middleValue = nums[middle];
            if (middleValue == target)
            {
                return middle;
            }

            if(middleValue > target)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        if(nums[left] >= target)
        {
            return left;
        }

        return left + 1;
    }
}