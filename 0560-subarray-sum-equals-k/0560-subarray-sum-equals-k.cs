public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0;
        int sum = 0;
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            sum = 0;
            for (int j = i; j < length; j++)
            {
                sum += nums[j];
                if (sum == k)
                    result++;
            }
        }
        return result;
    }
}