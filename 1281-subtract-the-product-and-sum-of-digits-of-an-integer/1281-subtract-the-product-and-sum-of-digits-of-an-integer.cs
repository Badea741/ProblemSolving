public class Solution {
    public int SubtractProductAndSum(int n) {
        if(n==1)return 0;
        int product = 1;
        int sum = 0;
        while (n >=1)
        {
            int nextDigit = n % 10;
            product *= nextDigit;
            sum += nextDigit;
            n /= 10;
        }
        return product - sum;
    }
}