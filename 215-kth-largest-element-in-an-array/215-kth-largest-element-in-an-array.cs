public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        List<int> numsList=nums.ToList();
        for(int i =0;i<k-1;i++){
            numsList.Remove(numsList.Max());
        }
        return numsList.ToArray().Max();
    }
}