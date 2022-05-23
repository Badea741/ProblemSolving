public class Solution
{
    public  int HammingWeight(uint n)
    {
        int count = 0;
        string number = n.ToString();
        while (n > 0)
        {
            if ((n & 1) >= 1) count++;
            n >>= 1;
        }
        return count;
    }
   
}