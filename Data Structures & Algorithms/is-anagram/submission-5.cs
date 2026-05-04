public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
    return false;
Dictionary<char, int> set = new Dictionary<char, int>();
Dictionary<char, int> set2 = new Dictionary<char, int>();
foreach (char c in s)
{
    if (!set.ContainsKey(c))
    {
        set.Add(c, 1);
    }
    else
    {
        set[c]++;
    }
}
foreach (char c in t)
{
    if (!set2.ContainsKey(c))
    {
        set2.Add(c, 1);
    }
    else
    {
        set2[c]++;
    }
}
foreach(var key in set.Keys)
{
    if (!set2.ContainsKey(key) || set[key] != set2[key])
    {
        return false;
    }
    if (set[key] != set2[key])
    {
        return false;
    }
}
return true;
    }
}
