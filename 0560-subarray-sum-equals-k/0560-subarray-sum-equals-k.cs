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
        int[] prefix = nums.PrefixSum();
        for (int i = 0; i < length; i++)
            for (int j = i; j < length; j++)
            {
                if (prefix.RangeSum(i, j) == k)
                    result++;
            }
        return result;
    }
}