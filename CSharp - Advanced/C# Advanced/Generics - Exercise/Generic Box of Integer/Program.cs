using GenericBoxOfString;

Box<int> box = new();

int numOfInput = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfInput; i++)
{
    int input = int.Parse(Console.ReadLine());
    box.Add(input);

}

Console.WriteLine(box.ToString());