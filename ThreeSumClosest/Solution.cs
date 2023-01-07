namespace ThreeSumClosest;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var globalMin = int.MaxValue;
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k)
            {
                var sum = nums[i] + nums[j] + nums[k];
                var diff = Math.Abs(target - sum);
                if (diff == 0)
                {
                    return sum;
                }

                if (diff < globalMin)
                {
                    globalMin = diff;
                    result = sum;
                }

                if (sum <= target)
                {
                    j++;
                }
                else
                {
                    k--;
                }
            }
        }

        return result;
    }

    public int ThreeSumClosest1(int[] nums, int target)
    {
        var result = int.MinValue;
        var diff = int.MaxValue;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                for (var k = j + 1; k < nums.Length; k++)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    var localDiff = Math.Abs(sum - target);
                    if (localDiff < diff)
                    {
                        if (localDiff == 0)
                        {
                            return target;
                        }

                        diff = localDiff;
                        result = sum;
                    }
                }
            }
        }

        return result;
    }
}