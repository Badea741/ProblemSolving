public class Solution {
    public int MaxArea(int[] height) {
         int max = 0;
        int left = 0;
        int right = height.Length - 1;
        while (left < right)
        {
            int area = Math.Min(height[left], height[right]) * Math.Abs(left - right);
            if (max < area) max = area;
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return max;
}
}