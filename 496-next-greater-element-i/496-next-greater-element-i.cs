public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
       Stack<int> stack = new();
        Dictionary<int, int> dict = new();
        foreach (int num in nums2)
        {
            while (stack.Count != 0 && num > stack.Peek())
            {
                dict[stack.Pop()] = num;
            }
            stack.Push(num);
        }
        int i = 0;
        foreach (int num in nums1)
        {
            nums1[i] = dict.GetValueOrDefault(num, -1);
            i++;
        }
        return nums1;
    }
}