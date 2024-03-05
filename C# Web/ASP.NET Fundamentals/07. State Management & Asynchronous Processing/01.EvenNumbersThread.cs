//Reading data
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

Thread evens = new Thread(() => PrintEvenNumbers(start, end));

evens.Start();
evens.Join();
Console.WriteLine("Thread Finished Work");

static void PrintEvenNumbers(int start, int end)
{
	for (int i = start; i <= end; i++)
	{
		Console.WriteLine(i);
	}
}
