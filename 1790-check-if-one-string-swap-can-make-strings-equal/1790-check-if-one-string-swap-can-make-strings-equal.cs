public class Solution
{

    public static int CountCharacter(string s, char c)
    {
        byte[] arr = new byte[] { };
        int count = 0;
        foreach (char c1 in s)
        {
            if (c1 == c) count++;
        }
        return count;
    }
    public bool AreAlmostEqual(string s1, string s2)
    {

        if (s1 == s2) return true;
        int n = s1.Length;

        int count = 0;
        for (int i = 0; i < n; ++i)
        {
            if (CountCharacter(s1, s1[i]) != CountCharacter(s2, s1[i])) return false;
            if (s1[i] != s2[i]) count++;
        }
        if (count == 0 || count == 2) return true;
        return false;
    }
}