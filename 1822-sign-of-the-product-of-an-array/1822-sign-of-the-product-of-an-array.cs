public class Solution {
    public int ArraySign(int[] nums) {
          int product = 1;
        foreach (int num in nums)
        {
            if (num == 0) return 0;
            if (num < 0) product = -product;
        }
        return product;
    }
}