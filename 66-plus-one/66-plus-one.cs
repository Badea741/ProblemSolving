public class Solution {
    public int[] PlusOne(int[] digits) {
       int i = digits.Length - 1;
        int lastPosition = digits.Length - 1;
        int mostSignificantDigit = digits[lastPosition];
        List<int> alist = new();

        if (mostSignificantDigit < 9)
        {
            digits[lastPosition]++;
            alist = digits.ToList();
        }
        else
        {
            if (lastPosition == 0) { alist.Add(0); alist.Add(1); }
            while (digits[i] == 9 && i > 0)
            {
                digits[i] = 0;
                i--;
            }
            if (digits[i] < 9 && mostSignificantDigit == 9)
            {
                digits[i]++;
                alist = digits.ToList();
            }
            else
            {
                digits[i] = 0;
                alist = digits.ToList();
                alist.Insert(0, 1);
            }
        }
        return alist.ToArray();


    }
}