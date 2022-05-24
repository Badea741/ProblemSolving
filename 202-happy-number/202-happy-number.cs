public class Solution {
    public bool IsHappy(int n) {
        int count = 0;
        Dictionary<int,int> keyValue=new();
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
            if(keyValue.ContainsKey(n))return false;
            keyValue.Add(n,count);
        }
        return true;
    }
}