
int numOfOperations = int.Parse(Console.ReadLine());

string text = string.Empty;
var stack = new Stack<string>();

for (int i = 0; i < numOfOperations; i++)
{
    string[] tokens = Console.ReadLine()
      .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int command = int.Parse(tokens[0]);

    switch (command)
    {
        case 1:
            stack.Push(text);
            text += tokens[1];
            break;
        case 2:
            stack.Push(text);
            int count = int.Parse(tokens[1]);
            text = text.Remove(text.Length - count);
            break;
        case 3:
            int index = int.Parse(tokens[1]) - 1;
            Console.WriteLine(text[index]);
            break;
        case 4:
            text = stack.Pop();
            break;
    }
}