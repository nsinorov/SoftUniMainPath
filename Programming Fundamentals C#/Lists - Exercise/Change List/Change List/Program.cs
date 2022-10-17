using System;
using System.Linq;
using System.Collections.Generic;

namespace Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
                  
            while(command != "end")
            {
                string[] commands = command.Split();
                string cmd = commands[0];

                if (cmd == "Delete")
                {
                    int num = int.Parse(commands[1]);

                    numbers.RemoveAll(el => el == num);
                }

               else if(cmd == "Insert")
                {
                    int num = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);

                    numbers.Insert(index, num);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
