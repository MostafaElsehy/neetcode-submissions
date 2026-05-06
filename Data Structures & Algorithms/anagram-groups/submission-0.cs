public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
foreach (string str in strs)
{
    char[] word = str.ToCharArray();
    Array.Sort(word);
    string key = new string(word);
    if(!dict.ContainsKey(key))
    {
        dict[key] = new List<string>();
    }
    dict[key].Add(str);
}
return dict.Values.ToList();
    }
}
