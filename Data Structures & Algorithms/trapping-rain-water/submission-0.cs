public class Solution {
    public int Trap(int[] height) {
        int TotalTrappedWater = 0;
        int[] MaxLeft = new int[height.Length];
        MaxLeft[0] = height[0];
        for(int i = 1; i < height.Length; i++)
        {
            MaxLeft[i] = Math.Max(MaxLeft[i - 1], height[i]);
        }
        int[] MaxRight = new int[height.Length];
        MaxRight[height.Length - 1] = height[height.Length - 1];
        for(int i = height.Length - 2; i >= 0; i--)
        {
            MaxRight[i] = Math.Max(MaxRight[i + 1], height[i]);
        }
        for(int i = 0; i < height.Length; i++)
        {
            TotalTrappedWater += Math.Min(MaxLeft[i], MaxRight[i]) - height[i];
        }
        return TotalTrappedWater;
    }
}
