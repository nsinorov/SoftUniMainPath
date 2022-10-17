using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string commands = Console.ReadLine();
           
            while(commands != "End")
            {
                string[] cmds = commands.Split();
                string command = cmds[0];

                if (command == "Add")
                {
                    int num = int.Parse(cmds[1]);
                    numbers.Add(num);
                }
                else if(command == "Insert")
                {
                    int num = int.Parse(cmds[1]);
                    int index = int.Parse(cmds[2]);

                    if(index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, num);

                }
                else if(command == "Remove")
                {
                    int index = int.Parse(cmds[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if(command == "Shift")
                {
                    int count = int.Parse(cmds[2]);
                    if (cmds[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (cmds[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
               commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
