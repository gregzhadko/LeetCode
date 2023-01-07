namespace ContainerWithMostWater;

public class Solution
{
    public int MaxArea(int[] height)
    {
        var result = 0;
        var leftPointer = 0;
        var rightPointer = height.Length - 1;

        while (leftPointer < rightPointer)
        {
            var area = CalculateArea(height, leftPointer, rightPointer);
            if(area > result)
            {
                result = area;
            }
            
            if(height[leftPointer] < height[rightPointer])
            {
                leftPointer++;
            }
            else
            {
                rightPointer--;
            }
        }

        return result;
    }
    
    private static int CalculateArea(int[] height, int leftIndex, int rightIndex)
    {
        var left = height[leftIndex];
        var right = height[rightIndex];
        var h = left < right ? left : right;
        var w = rightIndex - leftIndex;
        return h * w;
    }
}