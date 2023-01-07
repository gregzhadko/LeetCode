using Xunit;

namespace MedianOfTwoSortedArrays;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var nums1 = new int[] { 1, 3 };
        var nums2 = new int[] { 2 };
        var result = new Solution().FindMedianSortedArrays(nums1, nums2);
        Assert.Equal(2.0, result);
    }
    
    [Fact]
    public void Test2()
    {
        var nums1 = new int[] { 1, 2 };
        var nums2 = new int[] { 3, 4 };
        var result = new Solution().FindMedianSortedArrays(nums1, nums2);
        Assert.Equal(2.5, result);
    }
    
    [Fact]
    public void Test3()
    {
        var nums1 = new int[] { 1, 3 };
        var nums2 = new int[] { 2, 7 };
        var result = new Solution().FindMedianSortedArrays(nums1, nums2);
        Assert.Equal(2.5, result);
    }
    
    
}