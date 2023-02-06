using CustomDoublyLinkedList;

public class StartUp
{
    private static void Main(string[] args)
    {
        DoublyLinkedList nums = new DoublyLinkedList();

        nums.AddFirst(1);
        nums.AddFirst(2);
        nums.AddFirst(3);
        nums.AddFirst(4);

        nums.AddLast(5);
        nums.AddLast(6);
        nums.AddLast(7);
        nums.AddLast(8);
        nums.AddLast(9);

        nums.RemoveFirst();
        nums.RemoveLast();

        nums.ForEach(x => { });
        nums.ToArray();

        foreach (var letters in nums.ToArray())
        {
            Console.Write($"{letters} ");
        }

        Console.WriteLine();
        Console.WriteLine(nums.Count);
    }
}