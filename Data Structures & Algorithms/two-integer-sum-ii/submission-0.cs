public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
int right = numbers.Length - 1;
while (left < right)
{
    if (target == numbers[right] + numbers[left])
    {
        return [left + 1, right + 1];
    }
    else if (target < numbers[right] + numbers[left])
    {
        right--;
    }
    else
    {
        left++;
    }
}
return [left + 1, right + 1];
    }
}
