using System;

namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] currArticles = Console.ReadLine().Split(", ");

            var articles = new Article(currArticles[0], currArticles[1], currArticles[2]);

            int countOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfChanges; i++)
            {
                string[] lines = Console.ReadLine().Split(": ");
                string command = lines[0];
                string argument = lines[1];

                switch (command)
                {
                    case "Edit":
                        articles.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        articles.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        articles.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(articles);
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public void Rename(string title) => Title = title;
        
        public void Edit(string content) => Content = content;

        public void ChangeAuthor(string author) => Author = author;

        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
