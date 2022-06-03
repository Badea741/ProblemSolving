public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> dict=new();
        for(int i =0;i<nums.Length;i++){
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]]=1;
                continue;
            }
            dict[nums[i]]++;
        }
        foreach(var i in dict){
            if(i.Value>=2)return true;
        }
        return false;
    }
}