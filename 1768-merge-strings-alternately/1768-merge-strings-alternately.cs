public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder ans=new();
        int n = word1.Length;
        if(n<=word2.Length){
            for(int i=0;i<n;i++){
                ans.Append(word1[i]);
                ans.Append(word2[i]);
            }
            for(int i = word1.Length;i<word2.Length;i++){
                ans.Append(word2[i]);
            }
        }
        else{
            for(int i=0;i<word2.Length;i++){
                ans.Append(word1[i]);
                ans.Append(word2[i]);
            }
            for(int i = word2.Length;i<word1.Length;i++){
                ans.Append(word1[i]);
            }
        }
        
        return ans.ToString();
    }
}