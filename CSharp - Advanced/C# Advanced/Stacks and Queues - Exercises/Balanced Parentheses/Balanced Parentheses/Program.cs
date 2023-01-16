string parentheses = Console.ReadLine();

var stack = new Stack<char>();

foreach (var parenthes in parentheses)
{
    switch (parenthes)
    {
        case '(':      
        case '{':     
        case '[':
            stack.Push(parenthes); // pushing the opening brackets
            break;

        case '}':
            if(stack.Count == 0 || stack.Pop() != '{')
            {
                Console.WriteLine("NO");
                return;
            }
            break;

        case ')':
            if (stack.Count == 0 || stack.Pop() != '(')
            {
                Console.WriteLine("NO");
                return;
            }
            break;

        case ']':
            if (stack.Count == 0 || stack.Pop() != '[')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
    }
}

if (stack.Count > 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}