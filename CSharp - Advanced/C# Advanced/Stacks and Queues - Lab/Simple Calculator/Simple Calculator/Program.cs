// Split the input expression by space to extract its tokens
string[] tokens = Console.ReadLine().Split(' ').ToArray();
// Reverse the input tokens
Array.Reverse(tokens);
// Push the tokens in a stack
var stack = new Stack<string>(tokens);
// Initialize the current result as the first number in the stack
int result = int.Parse(stack.Pop());
// Repeat the following steps until the stack gets empty
while (stack.Count > 0)
{
    // Pop an operation and number
    string op = stack.Pop();
    int num = int.Parse(stack.Pop());

    // Execute the operation
    if (op == "+")
    {
        result += num;
    }
    else if (op == "-")
    {
        result -= num;
    }
}
// result
Console.WriteLine(result);