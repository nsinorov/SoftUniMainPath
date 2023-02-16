int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

HashSet<int> firstNums = new();
HashSet<int> secondNums = new();

for (int i = 0; i < nums[0]; i++)
{
    firstNums.Add(int.Parse(Console.ReadLine()));

}
for (int i = 0; i < nums[1]; i++)
{
    secondNums.Add(int.Parse(Console.ReadLine()));
}

firstNums.IntersectWith(secondNums);

Console.WriteLine(string.Join(" ", firstNums));