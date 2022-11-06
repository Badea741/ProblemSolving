public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0;
        int length = nums.Length;
        Dictionary<int, int> SumCount = new();
                SumCount[0] = 1;

        int prefixSum = 0;
        for (int i = 0; i < length; i++)
        {
            prefixSum += nums[i];
            if (SumCount.ContainsKey(prefixSum - k))
            {
                result += SumCount[prefixSum - k];
            }
            if (!SumCount.ContainsKey(prefixSum))
                SumCount[prefixSum] = 1;
            else
                SumCount[prefixSum]++;
        }

        return result;
    }
}