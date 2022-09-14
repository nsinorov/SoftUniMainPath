using System;

namespace Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentPass = Console.ReadLine();

            if (currentPass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else  
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
