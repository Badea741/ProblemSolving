public class Solution {
    public bool IsAnagram(string s, string t) {
        if(t.Length!=s.Length)return false;
        Dictionary<int,int> dict=new();
        Dictionary<int,int> dict1=new();
       foreach(char c in s){
            if(dict.ContainsKey(c)){dict[c]++;continue;}
            dict[c]=0;
            dict[c]++;
       }
        foreach(char c in t){
            if(!dict.ContainsKey(c))return false;
            if(dict1.ContainsKey(c)){dict1[c]++;continue;}
            dict1[c]=0;
            dict1[c]++;
        }
        foreach(char c in t){
            if(dict[c]!=dict1[c])return false;
        }
        return true;
        
    }
}