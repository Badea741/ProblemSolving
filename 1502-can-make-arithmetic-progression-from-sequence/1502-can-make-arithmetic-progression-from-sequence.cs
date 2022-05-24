public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int n=arr.Length;
        for(int i=0;i<n-1;++i){
            int difference=arr[1]-arr[0];
            if(arr[i+1]-arr[i]!=difference)return false;
        }
        return true;
    }
}