public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> dict=new();
        for(int i =0;i<nums.Length;i++){
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]]=1;
                nums[i]=1;
                continue;
            }
            nums[i]=2;
        }
        foreach(int i in nums){
            if(i>=2)return true;
        }
        return false;
    }
}