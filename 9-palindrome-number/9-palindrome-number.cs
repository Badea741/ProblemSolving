public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;
         List<int> y = new();
        while (x > 0)
        {
            y.Add(x % 10);
            x /= 10;
        }
        List<int> z = new();
        for (int i = y.Count-1; i >= 0; i--)
        {
            z.Add(y[i]);
        }
        return z.SequenceEqual(y);
    }//
}