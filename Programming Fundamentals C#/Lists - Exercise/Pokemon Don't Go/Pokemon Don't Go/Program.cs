using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            int index;
            int currValue;
            int sum = 0;

            while (sequence.Count != 0)
            {
                index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    currValue = sequence[0];
                    sum += currValue;
                    sequence[0] = sequence[sequence.Count - 1];

                }
                else if (index > sequence.Count - 1)
                {
                    currValue = sequence[sequence.Count - 1];
                    sum += currValue;
                    sequence[sequence.Count - 1] = sequence[0];
                }
                else
                {
                    currValue = sequence[index];
                    sum += currValue;
                    sequence.RemoveAt(index);
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= currValue)
                    {
                        sequence[i] += currValue;
                    }
                    else
                    {
                        sequence[i] -= currValue;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
