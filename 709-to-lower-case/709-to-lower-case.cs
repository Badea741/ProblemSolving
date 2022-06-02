using System.Text;

public class Solution
{
    public  string ToLowerCase(string s)
    {
         int n = s.Length;
        StringBuilder ans = new();
        for (int i = 0; i < n; i++)
        {
            if (s[i] < 91&&s[i]>=65)
            {
                ans.Append((char)(s[i] + 32));
                continue;
            };
            ans.Append(s[i]);
        }
        return ans.ToString();
    }
}