int numOfUnputs = int.Parse(Console.ReadLine());

Dictionary<int, int> numOfOccurences= new();

for (int i = 0; i < numOfUnputs; i++)
{
    int nums = int.Parse(Console.ReadLine());

    if (!numOfOccurences.ContainsKey(nums))
    {
        numOfOccurences.Add(nums, 0);
    }

    numOfOccurences[nums]++;
}

Console.WriteLine(numOfOccurences.Single(n => n.Value % 2 == 0).Key);