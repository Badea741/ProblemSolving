public class Solution {
   public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> x=new();
        int[] result=new int[2];
        for(int i=0;i<nums.Length;i++){
            if(x.ContainsKey(nums[i])){
                result[0]=i;
                result[1]=x[nums[i]];
            }
            x[target-nums[i]]=i;
            
        }
       return result;
    }
}