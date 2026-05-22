public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new List<List<int>>();
Array.Sort(nums);
for (int i = 0; i < nums.Length - 2; i++)
{
    int left = i + 1;
    int right = nums.Length - 1;
    while (left < right)
    {
        if (-nums[i] == nums[right] + nums[left])
        {
            result.Add(new List<int>() { nums[i], nums[left], nums[right] });
            left++;
        }
        else if (-nums[i] < nums[right] + nums[left])
        {
            right--;
        }
        else
        {
            left++;
        }
    }
}

    return result.
    GroupBy(x => string.Join(",", x)).
    Select(g => g.First()).ToList() ;
    }
}
