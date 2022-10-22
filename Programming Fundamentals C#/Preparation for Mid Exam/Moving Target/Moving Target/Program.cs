using System;
using System.Linq;
using System.Collections.Generic;

namespace Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            List <int> sequenceOfTargets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine(); // Shoot 2 2
                    
            while (command != "End")
            {
                string[] commandInfo = command.Split(); // "Shoot" "2" "2"
                string commandName = commandInfo[0]; // "Shoot"
                int index = int.Parse(commandInfo[1]); // "2"
                int value = int.Parse(commandInfo[2]); // "2"

                if(commandName == "Shoot")
                {
                    if(index >= 0 && index < sequenceOfTargets.Count) // IMPORTANT TO CHECK IF the given index is inside in the List/array
                    {
                        sequenceOfTargets[index] -= value;

                        if(sequenceOfTargets[index] <= 0)
                        {
                            sequenceOfTargets.RemoveAt(index); // we remove the given index 1,2,3,4,5 -> we remove some of the num 
                        }
                    }
                }
                else if(commandName == "Add")
                {
                    if(index >= 0 && index < sequenceOfTargets.Count) // check if we are inside again
                    {
                        sequenceOfTargets.Insert(index, value); // we add to the given index the given value
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if(commandName == "Strike")
                {
                    //starting point from where we elim to where it ends
                    //1,2,3,4,5
                    // 0 >= 0 && 4 < 5  -> you are inside
                    
                    if(index - value >= 0 && index + value < sequenceOfTargets.Count)
                    {
                        //                          starting index and how much should be removed
                        sequenceOfTargets.RemoveRange(index - value, value * 2 + 1);
                        //                                    2 - 2, 2*2 + 1 --> from 0 index to 5th index will be removed
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", sequenceOfTargets));
        }
    }
}
