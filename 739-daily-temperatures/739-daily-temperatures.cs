public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
       int n = temperatures.Length;
        int[] result = new int[n];
        LinkedList<(int, int)> deque = new();
        for (int i = 0; i < n; i++)
        {
            while (deque.Count != 0 && deque.Last.Value.Item1 < temperatures[i])
            {
                result[deque.Last.Value.Item2] = i - deque.Last.Value.Item2;
                deque.RemoveLast();
            }
            deque.AddLast(new LinkedListNode<(int, int)>((temperatures[i], i)));
        }
        while (deque.Count != 0)
        {
            result[deque.Last.Value.Item2] = 0;
            deque.RemoveLast();
        }

        return result;
}
}