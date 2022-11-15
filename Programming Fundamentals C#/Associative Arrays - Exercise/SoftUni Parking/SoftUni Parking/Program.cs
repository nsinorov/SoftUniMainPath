using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var users = new Dictionary<string, string>();

            int numOfCmds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCmds; i++)
            {
                var commands = Console.ReadLine().Split();

                var action = commands[0];
                var userName = commands[1];

                switch(action)                   
                {
                    case "register":
                        var plateNumber = commands[2];

                        if (CheckIfUserDoesNotExist(users, userName))
                        {
                            users.Add(userName, plateNumber);
                            Console.WriteLine($"{userName} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;

                    case "unregister":
                        if (CheckIfUserDoesNotExist(users, userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{userName} unregistered successfully");
                            users.Remove(userName);
                        }
                            break;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static bool CheckIfUserDoesNotExist(Dictionary<string,string> users, string name) => !users.ContainsKey(name);
    }
}
