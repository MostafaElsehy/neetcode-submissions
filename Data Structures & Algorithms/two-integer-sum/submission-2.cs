public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] twoIndecies = new int[2];
Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < nums.Length; i++)
{
    int comp = target - nums[i];
    if (dict.ContainsKey(comp))
    {
        twoIndecies[0] = dict[comp];
        twoIndecies[1] = i;
    }
    dict[nums[i]] = i;
}
return twoIndecies;
    }
}
