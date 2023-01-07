namespace ThreeSum;

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k)
            {
                switch (nums[i] + nums[j] + nums[k])
                {
                    case 0:
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
                        j++;
                        k--;
                        while (j < k && nums[j] == nums[j - 1])
                        {
                            j++;
                        }
                        while (j < k && nums[k] == nums[k + 1])
                        {
                            k--;
                        }

                        break;
                    }
                    case < 0:
                        j++;
                        break;
                    default:
                        k--;
                        break;
                }
            }
        }

        return result;
    }
}