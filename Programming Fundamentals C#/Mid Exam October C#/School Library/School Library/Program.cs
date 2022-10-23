using System;
using System.Linq;
using System.Collections.Generic;

namespace School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bookShelf = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> commands = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (commands[0] != "Done")
            {
                // we read the first command that is given
                // then we add/remove/insert...
                if (commands[0] == "Add Book")
                {
                    string bookName = commands[1];

                    if (!bookShelf.Contains(bookName))
                    {
                        bookShelf.Insert(0, bookName);
                    }
                }

                else if (commands[0] == "Take Book")
                {
                    string bookName = commands[1];
                    if(bookShelf.Find(x => x == bookName) == bookName)
                    {
                        bookShelf.Remove(bookName);
                    }
                 
                }

                else if (commands[0] == "Swap Books")
                {
                    string bookOne = commands[1];
                    string bookTwo = commands[2];

                    if (bookShelf.Contains(bookOne) && bookShelf.Contains(bookTwo))
                    {
                        int indexOfBookOne = bookShelf.IndexOf(bookOne);
                        int indexOfBookTwo = bookShelf.IndexOf(bookTwo);
                        bookShelf.RemoveAt(indexOfBookOne);
                        bookShelf.Insert(indexOfBookOne, bookTwo);
                        bookShelf.RemoveAt(indexOfBookTwo);
                        bookShelf.Insert(indexOfBookTwo, bookOne);
                    }
                }

                else if (commands[0] == "Insert Book")
                {
                    string bookName = commands[1];
                    if(bookShelf.Find(x => x == bookName) != bookName)
                    {
                        bookShelf.Add(bookName);
                    }              
                }

                else if (commands[0] == "Check Book")
                {
                    int index = int.Parse(commands[1]);

                    if (index >= 0 && index <= bookShelf.Count)
                    {
                        Console.WriteLine(bookShelf[index]);
                    }
                }

                commands = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine(string.Join(", ", bookShelf));
        }
    }
}
