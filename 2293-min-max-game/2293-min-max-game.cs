public class Solution {
    public int MinMaxGame(int[] nums) {
            if (nums.Length == 1) return nums[0];
        if (nums.Length == 2) return Math.Min(nums[0], nums[1]);
        int n = nums.Length;
        int count = 2;
        int[] newNums = new int[n / count];
        while (newNums.Length > 1)
        {
            for (int i = 0; i < n / count; i++)
            {
                if ((i & 1) == 0)
                {
                    newNums[i] = Math.Min(nums[2 * i], nums[2 * i + 1]);
                    continue;
                }
                if ((i & 1) == 1)
                {
                    newNums[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);
                    continue;
                }
            }
            count *= 2;
            nums = newNums;

            newNums = new int[n / count];

        }
       return nums.Length == 1 ? nums[0] : Math.Min(nums[0], nums[1]);
    }
}