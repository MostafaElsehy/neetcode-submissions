public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
int left = 0;
int right = heights.Length - 1;

while (left < right)
{
    int width = right - left;
    int minHeight = Math.Min(heights[right], heights[left]);
    int intialArea = width * minHeight;
    maxArea = Math.Max(maxArea, intialArea);
    if (heights[right] < heights[left])
    {
        right--;
    }
    else
    {
        left++;
    }
}
return maxArea;
    }
}
