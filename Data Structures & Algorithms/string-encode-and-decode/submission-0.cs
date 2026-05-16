public class Solution {

    public string Encode(IList<string> strs) {
         string encodedString = "";
 foreach (string str in strs)
 {
     encodedString = encodedString + str.Length + '#' + str;
 }
 return encodedString;
    }

    public List<string> Decode(string s) {
        List<string> decodedStrs = new List<string>();
while (s.Contains('#'))
{
    int indexOfHash = s.IndexOf('#');
    int numberOfStringChars = Convert.ToInt32(s.Substring(0, indexOfHash));
    string str = s.Substring(indexOfHash + 1, numberOfStringChars);
    decodedStrs.Add(str);
    s = s.Substring(indexOfHash + numberOfStringChars + 1);
}
return decodedStrs;
   }
}
