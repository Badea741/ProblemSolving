public class Solution {
    public bool IsAnagram(string s, string t) {
        if(t.Length!=s.Length)return false;
        Dictionary<int,int> dict=new();
      for(int i =0;i<s.Length;i++){
          if(dict.ContainsKey(s[i])){
              dict[s[i]]++;
          }
          else dict[s[i]]=1;
          if(dict.ContainsKey(t[i])){
              dict[t[i]]--;
          }
          else dict[t[i]]=-1;
      }
        foreach(var x in dict){
            if(x.Value>=1)return false;
        }
        return true;
    }
}