int[] tokens = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

var stack = new Stack<int>();

int pushElement = tokens[0];
int popElement = tokens[1];
int checkNum = tokens[2];

for (int i = 0; i < pushElement; i++)
{
    stack.Push(nums[i]);
}

for (int i = 0; i < popElement; i++)
{
    stack.Pop();
}

if (stack.Contains(checkNum))
{
    Console.WriteLine("true");
}
else
{
    if (stack.Any())
    {
        Console.WriteLine(stack.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}