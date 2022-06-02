public class Solution {
    public string FreqAlphabets(string s) {
        Stack<char> stack = new();
        StringBuilder ans = new();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            StringBuilder block = new();
            if (s[i] == '#') stack.Push(s[i]);
            int numericCharacter = (int)Char.GetNumericValue(s[i]);
            if (numericCharacter <= 9 && numericCharacter != -1 && stack.Contains('#')) stack.Push(s[i]);
            if (stack.Count >= 3)
            {
                while (stack.Count != 0)
                    block.Append(stack.Pop());
                string blockString = block.ToString();
                int blockNumber = int.Parse(string.Concat(blockString[0], blockString[1]));
                if (blockNumber <= 26 && blockNumber >= 10)
                {
                    ans.Append((char)(blockNumber + 96));
                    continue;
                }
            }
            if (numericCharacter >= 0 && numericCharacter <= 9 && stack.Count == 0)
                ans.Append((char)(numericCharacter + 96));
        }
        char[] chars = ans.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}