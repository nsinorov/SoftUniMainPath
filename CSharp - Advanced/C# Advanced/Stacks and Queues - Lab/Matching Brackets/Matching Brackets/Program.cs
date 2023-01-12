string input = Console.ReadLine();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        stack.Push(i);
    }
    if (input[i] == ')')
    {
        int openBracket = stack.Pop();

        for (int j = openBracket; j <= i; j++)
        {
            if (input[j] == ' ')
            {
                continue;
            }
            Console.Write(input[j]);
        }
        Console.WriteLine();
    }
}