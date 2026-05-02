class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        unordered_map<int, int> n;
int s = nums.size();
for (int i = 0; i < s; i++)
{
    if (++n[nums[i]] > 1)
    {
        return true;
    }
}
return false;
    }
};