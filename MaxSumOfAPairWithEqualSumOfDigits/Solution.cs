namespace MaxSumOfAPairWithEqualSumOfDigits;

public class Solution
{
    public int MaximumSum(int[] nums)
    {
        var dict = new Dictionary<int, List<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var sum = GetDigitsSum(num);

            if (dict.TryGetValue(sum, out var value))
            {
                if (value.Count == 2)
                {
                    if (value[0] < value[1])
                    {
                        if (value[0] < nums[i])
                        {
                            value[0] = nums[i];
                        }
                    }
                    else
                    {
                        if (value[1] < nums[i])
                        {
                            value[1] = nums[i];
                        }
                    }
                }
                else
                {
                    value.Add(nums[i]);
                }
            }
            else
            {
                dict.Add(sum, new(2) { nums[i] });
            }
        }

        return dict.Select(d => d.Value).Where(v => v.Count == 2).Select(v => v[0] + v[1]).DefaultIfEmpty(-1).Max();
    }

    private static int GetDigitsSum(int num)
    {
        var sum = 0;
        while (num / 10 > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        sum += num;
        return sum;
    }
}