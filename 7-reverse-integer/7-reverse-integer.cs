

public class Solution
{
    public int Reverse(int x)
    {
        int newInt = 0;
        int i = 0;
        StringBuilder builder = new();
        if (x < 0)
        {
            while (x <= -1)
            {
                newInt += (x % 10) * (int)Math.Pow(10, i);
                x = x / 10;
                i++;

            }

            builder.Append(newInt);
            char[] convertedString0 = builder.ToString().ToArray();
            Array.Reverse(convertedString0);
            try
            {
                return -int.Parse(new String(convertedString0).Substring(0, convertedString0.Length - 1));
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
        while (x >= 1)
        {
            newInt += (x % 10) * (int)Math.Pow(10, i);
            x = x / 10;
            i++;
        }

        builder.Append(newInt);
        char[] convertedString1 = builder.ToString().ToArray();
        Array.Reverse(convertedString1);
        try
        {
            return int.Parse(new String(convertedString1));
        }
        catch (OverflowException)
        {
            return 0;
        }
    }
}