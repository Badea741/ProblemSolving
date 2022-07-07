public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
       int n = temperatures.Length;
        int[] result = new int[n];
        Stack<(int, int)> stack = new();
        for (int i = 0; i < n; i++)
        {
            while (stack.Count != 0 && stack.Peek().Item1 < temperatures[i])
            {
                result[stack.Peek().Item2] = i - stack.Peek().Item2;
                stack.Pop();
            }
            stack.Push((temperatures[i], i));
        }
        while (stack.Count != 0)
        {
            result[stack.Peek().Item2] = 0;
            stack.Pop();
        }

        return result;
}
}