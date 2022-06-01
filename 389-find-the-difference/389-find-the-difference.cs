public class Solution {
    public char FindTheDifference(string s, string t) {
        byte[] arr1=new byte[256];
        byte[] arr2=new byte[256];
        foreach(char c in s){
            arr1[c]++;
        }
        foreach(char c in t){
            arr2[c]++;
            if(arr1[c]<arr2[c])return c;
        }
        // foreach(char c in t){
        //     if(arr1[c]<arr2[c])return c;
        // }
        return 'a';
    }
}