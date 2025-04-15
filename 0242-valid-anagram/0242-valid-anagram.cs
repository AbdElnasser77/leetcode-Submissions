public class Solution {
    public bool IsAnagram(string s, string t) {
  var str1 = new Dictionary<char,int>();
var str2 = new Dictionary<char,int>();
foreach(char c in s)
{
    if(str1.ContainsKey(c)) str1[c]++;
    else str1[c] = 1;
}
foreach(char c in t)
{
    if(str2.ContainsKey(c)) str2[c]++;
    else str2[c] = 1;
}

bool areEqual = str1.Count == str2.Count && !str1.Except(str2).Any();

return areEqual;    
    }
}