using GenericBoxOfString;

Box<string> box = new();

int numOfInput = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfInput; i++)
{
    string input = Console.ReadLine();
    box.Add(input);

}

Console.WriteLine(box.ToString());