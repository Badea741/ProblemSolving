public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int n = arr.Length;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
            for (int j = i + 1; j < n; j++)
            {
                // if (j == i + 1) sum += arr[i];
                int x = (j+1) - i;
                if (x % 2 != 0)
                    for (int k = i; k <= j; k++)
                    {
                        sum += arr[k];
                    }
            }

        }
        return sum;
    }
}