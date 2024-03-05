using System.Runtime.CompilerServices;

while (true)
{
    string command = Console.ReadLine();

	if (command == "show")
	{
		var result = SumAsync();
		Console.WriteLine(result);
	}
}

static long SumAsync()
{
	return Task.Run(() =>
	{
		long sum = 0;

		for (int i = 1; i < 10000; i++)
		{
			if (i % 2 == 0)
			{
				sum += i;
			}
		}

		return sum;
	}).Result;
}
