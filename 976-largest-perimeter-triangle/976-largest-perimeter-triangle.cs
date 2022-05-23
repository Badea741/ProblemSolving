public class Solution {
    public int LargestPerimeter(int[] nums) {
      Array.Sort(nums);
        for (int i = nums.Length - 3; i >= 0; --i)
        {
            if (nums[i] + nums[i + 1] > nums[i + 2]) return nums[i + 2] + nums[i + 1] + nums[i];

        }
        return 0;
    }
}