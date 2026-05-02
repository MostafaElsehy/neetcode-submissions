class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        unordered_set<int> n;
        int s = nums.size();
        for(int i = 0; i < s; i++)
        {
            if(!n.insert(nums[i]).second) return true;
        }
        return false;
    }
};