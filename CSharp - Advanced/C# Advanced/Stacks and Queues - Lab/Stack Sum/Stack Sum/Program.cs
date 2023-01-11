//reading the numbers
List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

Stack<int> stack = new Stack<int>(input);

// our two commands -> add ; remove
string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] splittedCommand = command.Split();

    if (splittedCommand[0] == "add")
    {
        int firstNum = int.Parse(splittedCommand[1]);
        int secondNum = int.Parse(splittedCommand[2]);
        stack.Push(firstNum);
        stack.Push(secondNum);

    }
    if (splittedCommand[0] == "remove")
    {
        int n = int.Parse(splittedCommand[1]);
        // n needs to be < stack.Count so that we can make sure that we don't run out of numbers to remove.
        if (n <= stack.Count)
        {
            // we remove n times from the stack
            for (int i = 0; i < n; i++)
            {
                stack.Pop();
            }
        }
    }
    command = Console.ReadLine().ToLower();
}

int sum = 0;

while (stack.Count != 0)
{
    sum += stack.Pop();
}

Console.WriteLine($"Sum: {sum}");