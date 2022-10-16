using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input.Split();

                string command = inputParams[0];

                if(command == "Add")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }

                else if(command == "Remove")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                }

                else if(command == "RemoveAt")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.RemoveAt(value);
                }

                else if(command == "Insert")
                {
                    int value = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);

                    numbers.Insert(index, value);
                }

                input = Console.ReadLine();
            }

            Console.Write(string.Join(" ", numbers));
        }
    }
}
