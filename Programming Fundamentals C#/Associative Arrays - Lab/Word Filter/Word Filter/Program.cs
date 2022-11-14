using System;
using System.Linq;
using System.Collections.Generic;

namespace Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList().ForEach(Console.WriteLine);       
        }
    }
}
