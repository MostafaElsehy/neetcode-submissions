public class Solution {
    public string LetterString(string s)
    {
        string letterString = "";
        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                letterString += c;
            }
        }
        return letterString;
    }
    public bool IsPalindrome(string s) {
        s = LetterString(s);
        for(int i = 0; i < s.Length; i++)
        {
            if(char.ToUpper(s[i]) != char.ToUpper(s[s.Length - i - 1]))
            {
                return false;
            }
        }
        return true;
    }
}
