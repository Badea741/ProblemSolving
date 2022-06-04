public class Solution
{
    public static bool CompareArray(int[] nums1,int[] nums2){
        for(int i =0; i<nums1.Length;i++){
            if(nums1[i]!=nums2[i])return false;
        }
        return true;
    }
    public  bool IsMonotonic(int[] nums)
    {
        int[] notSorted = new int[nums.Length] ;
        Array.Copy(nums, notSorted, nums.Length);
        Array.Sort(nums);
        if (CompareArray(notSorted,nums)) return true;
        Array.Reverse(nums);
        if (CompareArray(notSorted,nums)) return true;
        return false;
    }
   
}