public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder ans=new();
        int n = word1.Length;
        int m = word2.Length;
        byte i =0,j=0;
        while(i<n||j<m){
            if(i<n)ans.Append(word1[i++]);
            if(j<m)ans.Append(word2[j++]);
        }
        
        return ans.ToString();
    }
}