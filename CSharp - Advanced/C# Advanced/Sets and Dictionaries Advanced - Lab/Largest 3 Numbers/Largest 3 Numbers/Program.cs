List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

numbers = numbers.OrderByDescending(x => x).Take(3).ToList();Console.WriteLine(string.Join(" ", numbers));