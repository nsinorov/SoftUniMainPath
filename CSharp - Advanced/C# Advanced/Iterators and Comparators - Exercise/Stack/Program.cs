using Stack;

CustomStack<string> customStack = new();

string command = string.Empty;

while((command = Console.ReadLine()) != "END")
{
    string[] tokens = command.Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];

    if(action == "Push")
    {
        foreach (var item in tokens.Skip(1))
        {
            customStack.Push(item);
        }
    }
    else
    {
        try
        {
            customStack.Pop();
        }
        catch (Exception exception)
        {

            Console.WriteLine(exception.Message);
        }
    }
}

foreach (var item in customStack)
{
    Console.WriteLine(item);
}
foreach (var item in customStack)
{
    Console.WriteLine(item);
}