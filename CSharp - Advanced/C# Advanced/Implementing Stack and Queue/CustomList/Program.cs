using CustomListFromScratch;

CustomList list = new();

list.Add(100);
list.Add(101);
list.Add(102);
list.Add(103);
list.Add(104);

list[1] = 324;

list.Add(105);
list.Add(106);
list.Add(107);
list.Add(108);

Console.WriteLine(list[1]);

Console.WriteLine(list.RemoveAt(0));
Console.WriteLine(list.RemoveAt(0));
Console.WriteLine(list.RemoveAt(0));
Console.WriteLine(list.RemoveAt(0));

Console.WriteLine(list.Count);