Func<int[], int> min = (nums) =>
{
	int min = int.MaxValue;

	foreach (var num in nums)
	{
		if (num < min)
		{
			min = num;
		}
	}
	return min;
};


int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Console.WriteLine(min(nums));