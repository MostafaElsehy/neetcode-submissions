public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] arr = new int[k];
Dictionary<int, int> dict = new Dictionary<int, int>();
foreach (var num in nums)
{
    if (!dict.ContainsKey(num))
    {
        dict.Add(num, 0);
    }
        dict[num]++;
}
List<int>[] arr2 = new List<int>[nums.Length + 1];
foreach(var item in dict)
{
    if (arr2[item.Value] == null)
    {
        arr2[item.Value] = new List<int>();
    }
    arr2[item.Value].Add(item.Key);
}
int c = 0;
for (int i = arr2.Length - 1; i >= 0; i--)
{
    if (arr2[i] != null)
    {
        foreach(var item in  arr2[i])
        {
            arr[c++] = item;
        }
    }
    if (c == k)
    {
        break;
    }
}
return arr;
    }
}
