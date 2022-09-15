using System;

namespace Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string favouriteBook = Console.ReadLine();
            int counter = 0;
            string input = Console.ReadLine();  


            while(input != "No More Books")
            {
                if (input == favouriteBook)
                {
                    break;
                }
               counter++;
               input = Console.ReadLine();
            }
            if(input == favouriteBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }        
        }
    }
}
