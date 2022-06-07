public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Dictionary<string, int> operandValue = new Dictionary<string, int>() { { "*", 0 }, { "/", 0 }, { "+", 1 }, { "-", 1 } };
        Stack<string> stack = new();
        int number = 0;

        foreach (string token in tokens)
        {
            stack.Push(token);
            if (operandValue.ContainsKey(stack.Peek()))
            {

                switch (stack.Pop())
                {
                    case "+":
                        number = int.Parse(stack.Pop()) + int.Parse(stack.Pop());
                        break;
                    case "*":
                        number = int.Parse(stack.Pop()) * int.Parse(stack.Pop());
                        break;
                    case "/":
                        double x = (double)double.Parse(stack.Pop());
                        double y = (double)double.Parse(stack.Pop());
                        number = (int) (y / x);
                        break;
                    case "-":
                        double w = (double)double.Parse(stack.Pop());
                        double z = (double)double.Parse(stack.Pop());
                        number = (int) (z - w);
                        break;
                }
                stack.Push(number.ToString());


            }
        }
        return int.Parse(stack.Pop());
    }
}