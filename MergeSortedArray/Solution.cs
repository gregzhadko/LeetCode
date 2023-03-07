namespace MergeSortedArray;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var i1 = m - 1;
        var i2 = n - 1;

        for (var i = m + n - 1; i >= 0; i--)
        {
            if (i1 < 0)
            {
                nums1[i] = nums2[i2];
                i2--;
            }
            else if (i2 < 0)
            {
                nums1[i] = nums1[i1];
                i1--;
            }
            else if (nums1[i1] > nums2[i2])
            {
                nums1[i] = nums1[i1];
                i1--;
            }
            else
            {
                nums1[i] = nums2[i2];
                i2--;
            }
        }
    }
}