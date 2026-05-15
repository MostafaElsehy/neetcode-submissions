public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
{
    return 0;
}
HashSet<int> set = new HashSet<int>(nums);
int longest = 0;
foreach (var item in set)
{
    if (!set.Contains(item - 1))
    {
        int currentNum = item;
        int currentStreak = 1;
        while (set.Contains(currentNum + 1))
        {
            currentNum++;
            currentStreak++;
        }
        longest = Math.Max(longest, currentStreak);
    }
}
return longest;
    }
}
