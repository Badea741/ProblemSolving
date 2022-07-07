public class Solution {
    public int LengthOfLastWord(string s) {
        // s=s.Trim();
        // string[] arr=s.Split();
        return s.Trim().Split()[^1].Length;
        // return arr[arr.Length-1].Length;
    }
}