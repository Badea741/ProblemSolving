public static class PrefixSumExtension
{
    
    public static int[] PrefixSum(this int[] array)
    {
        int length = array.Length;
        for (int i = 1; i < length; i++)
        {
            array[i] += array[i - 1];
        }
        return array;
    }
    public static int RangeSum(this int[] prefix, int start, int end)
    {
        if (start == 0) return prefix[end];
        return prefix[end] - prefix[start - 1];
    }
}
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