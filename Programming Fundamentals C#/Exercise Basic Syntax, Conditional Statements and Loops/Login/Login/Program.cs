using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string username = Console.ReadLine();
            int usernameLenght = username.Length - 1;
            string password = String.Empty;
            int count = 0;

            for (int i = usernameLenght; i >= 0; i--)
            {
                password += username[i];    
            }
            
            string inputPass = Console.ReadLine();

            while(inputPass != password)
            {
                count++;

                if(count > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
                inputPass = Console.ReadLine();
            }

            if(inputPass == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }      
        }
    }
}
