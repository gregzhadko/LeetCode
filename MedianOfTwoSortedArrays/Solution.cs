namespace MedianOfTwoSortedArrays;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0 && nums2.Length == 0)
        {
            return 0;
        }

        bool leftFinished = false, rightFinished = false;
        if (nums1.Length == 0)
        {
            leftFinished = true;
        }
        if (nums2.Length == 0)
        {
            rightFinished = true;
        }

        var left = int.MinValue;
        var right = int.MaxValue;

        var leftIndex = 0;
        var rightIndex = rightFinished ? nums1.Length - 1 : nums2.Length - 1;

        while (true)
        {
            var tempLeft = left;
            var tempRight = right;
            left = leftFinished ? nums2[leftIndex] : nums1[leftIndex];
            right = rightFinished ? nums1[rightIndex] : nums2[rightIndex];
            if (left == right)
            {
                return left;
            }
            if (left > right)
            {
                return (double)(tempRight + tempLeft) / 2;
            }

            leftIndex++;
            if(leftIndex > nums1.Length - 1)
            {
                leftIndex = 0;
                leftFinished = true;
            }
            
            rightIndex--;
            if(rightIndex < 0)
            {
                rightFinished = true;
                rightIndex = nums1.Length - 1;
            }
        }
    }
}