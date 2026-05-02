public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
foreach (int num in nums)
{
    if (!dict.ContainsKey(num))
    {
        dict.Add(num, 0);
    }
    dict[num]++;
    if (dict[num] > 1)
    {
        return true;
    }
}
return false;
    }
}