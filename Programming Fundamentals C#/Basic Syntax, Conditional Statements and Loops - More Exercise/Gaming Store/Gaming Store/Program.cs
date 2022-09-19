using System;

namespace Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            double budget = double.Parse(Console.ReadLine());
            double balance = budget;
            double remaining = 0;
            double totalSpent = 0;

            string command = Console.ReadLine();

            while (command != "Game Time")
            {
                if (command != "OutFall 4" && command != "CS: OG" && command != "Zplinter Zell" && command != "Honored 2" && command != "RoverWatch" && command != "RoverWatch Origins Edition")
                {
                     Console.WriteLine("Not Found");
                    
                    command = Console.ReadLine();
                }

                if (command == "OutFall 4" && balance < 39.99 || command == "CS: OG" && balance < 15.99 || command == "Zplinter Zell" && balance < 19.99 || command == "Honored 2" && balance < 59.99 || command == "RoverWatch" && balance < 29.99 || command == "RoverWatch Origins Edition" && balance < 39.99)
                {
                    Console.WriteLine("Too expensive");
                    command = Console.ReadLine();
                }

                if (command == "OutFall 4" && balance > 0)
                {
                    balance -= 39.99;
                    totalSpent += 39.99;
                    Console.WriteLine("Bought OutFall 4");
                }
                else if (command == "CS: OG" && balance > 0)
                {
                    balance -= 15.99;
                    totalSpent += 15.99;
                    Console.WriteLine("Bought CS: OG");
                }
                else if (command == "Zplinter Zell" && balance > 0)
                {
                    balance -= 19.99;
                    totalSpent += 19.99;
                    Console.WriteLine("Bought Zplinter Zell");
                }
                else if (command == "Honored 2" && balance > 0)
                {
                    balance -= 59.99;
                    totalSpent += 59.99;
                    Console.WriteLine("Bought Honored 2");
                }
                else if (command == "RoverWatch" && balance > 0)
                {
                    balance -= 29.99;
                    totalSpent += 29.99;
                    Console.WriteLine("Bought RoverWatch");
                }
                else if (command == "RoverWatch Origins Edition" && balance > 0)
                {
                    balance -= 39.99;
                    totalSpent += 39.99;
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
                remaining = balance;

                // if user is left with $0
                if(balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${remaining:F2}");
        }
    }
}
