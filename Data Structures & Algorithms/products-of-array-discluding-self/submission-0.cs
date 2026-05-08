public class Solution {
    public static int getPosOfZeroInArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)
        {
            return i;
        }
    }
    return -1;
}
public static int numsOfZeroInArr(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item == 0)
        {
            count++;
        }
    }
    return count;
}
public static int getProductOfAllElementsInArr(int[] arr)
{
    int result = 1;
    foreach (int item in arr)
    {
        if (item == 0)
        {
            continue;
        }
        result *= item;
    }
    return result;
}
    public int[] ProductExceptSelf(int[] nums) {
        int[] arrResult = new int[nums.Length];
int productOfAllElements = getProductOfAllElementsInArr(nums);
if (numsOfZeroInArr(nums) > 1)
{
    return arrResult;
}
else if(numsOfZeroInArr(nums) == 1)
{
    arrResult[getPosOfZeroInArr(nums)] = productOfAllElements;
    return arrResult;
}
for (int i = 0; i < nums.Length; i++)
{
    arrResult[i] = productOfAllElements / nums[i];
}
return arrResult;
    }
}
