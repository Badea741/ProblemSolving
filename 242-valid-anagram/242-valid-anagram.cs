public class Solution {
    public bool IsAnagram(string s, string t) {
        if(t.Length!=s.Length)return false;
        Dictionary<int,int> dict=new();
        Dictionary<int,int> dict1=new();
        for(int i =0;i<s.Length;i++){
            if(dict.ContainsKey(s[i])){dict[s[i]]++;continue;}
            dict[s[i]]=0;
            dict[s[i]]++;
        }
        foreach(char c in t){
            if(dict1.ContainsKey(c)){dict1[c]++;continue;}
            dict1[c]=0;
            dict1[c]++;
        }
        foreach(char c in t){
            if(!dict.ContainsKey(c)||dict[c]!=dict1[c])return false;
        }
        return true;
        
    }
}