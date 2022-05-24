public class Solution {
    public bool IsHappy(int n) {
        int count = 0;
        while (n > 1)
        {
            int sum = 0;
            int n2 = n;
            while (n2 >= 1)
            {
                sum += (int)Math.Pow(n2 % 10, 2);
                n2 /= 10;
            }
            n = sum;
            count++;
            if (count >= 20) return false;
        }
        return true;
    }
}