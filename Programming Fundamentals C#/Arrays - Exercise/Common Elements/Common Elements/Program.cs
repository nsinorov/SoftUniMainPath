using System;
using System.Linq;

namespace Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

             foreach (string currElement in arr1)
             {
                for (int i = 0; i < arr2.Length; i++)
                {
                    string secondCurrElement = arr2[i];

                    if(currElement == secondCurrElement)
                    {
                        Console.Write($"{currElement} ");
                       break;
                    }
                }
             }
        }
    }
}
