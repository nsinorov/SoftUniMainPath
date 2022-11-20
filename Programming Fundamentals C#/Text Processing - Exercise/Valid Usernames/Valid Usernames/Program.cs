using System;

namespace Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string currName in usernames)
            {
                if (currName.Length > 3 && currName.Length <= 16)
                {
                    bool isUsernameValid = true;

                    foreach (char currChar in currName)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }
                    if (isUsernameValid)
                    {
                        Console.WriteLine(currName);
                    }
                }
            }
        }
    }
}
