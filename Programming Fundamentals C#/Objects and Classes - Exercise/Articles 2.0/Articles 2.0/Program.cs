using System;
using System.Collections.Generic;

namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int numOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numOfArticles; i++)
            {
                string[] currArticles = Console.ReadLine().Split(", ");
                var article = new Article(currArticles[0], currArticles[1], currArticles[2]);

                articles.Add(article);

            }

            string input = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
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

        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
