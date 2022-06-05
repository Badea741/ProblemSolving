public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string str=s+s;
        return str.Substring(1,str.Length-2).Contains(s);
    }
}