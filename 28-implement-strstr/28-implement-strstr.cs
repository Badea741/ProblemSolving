public class Solution {
    // public int StrStr(string haystack, string needle) {
    //    for(int i=0;;i++)
    //        for(int j = 0;;j++){
    //            if(j>=needle.Length)return i;
    //            if(i+j>=haystack.Length)return -1;
    //            if(haystack[i+j]!=needle[j])break;
    //        }
    //     return -1;
    // }
    public int StrStr(string haystack, string needle) {
       return haystack.IndexOf(needle);
    }
}