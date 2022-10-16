﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = (Console.ReadLine());
                products.Add(product);        
            }
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
