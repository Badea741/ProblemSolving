public class Solution {
    public string Multiply(string num1, string num2) {
    BigInteger result = BigInteger.Parse(num1)*( BigInteger.Parse(num2));
        return result.ToString();
    }
}