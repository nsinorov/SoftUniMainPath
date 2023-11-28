namespace BookShop;

using BookShop.Models;
using BookShop.Models.Enums;
using Data;
using Initializer;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

public class StartUp
{
    public static void Main()
    {
        using var db = new BookShopContext();
        DbInitializer.ResetDatabase(db);

        //Input Values
        //string result = string.Empty;

        //UNCOMMENT THE EXERCISE YOU WANT TO TEST

        //O2.Age Restriction
        //string command = Console.ReadLine().ToLower();
        //result = GetBooksByAgeRestriction(db, command);

        //O3.Golden Books
        //result = GetGoldenBooks(db);

        //O4.Books by Price
        //result = GetBooksByPrice(db);

        //05.Not Released In
        //int year = int.Parse(Console.ReadLine());
        //result = GetBooksNotReleasedIn(db, year);

        //06.Book Titles By Category
        //string categories = Console.ReadLine();
        //result = GetBooksByCategory(db, categories);

        //07.Released Before Date
        //string date = Console.ReadLine();
        //result = GetBooksReleasedBefore(db, date);

        //08.Author Search
        //string endingCharacters = Console.ReadLine();
        //result = GetAuthorNamesEndingIn(db, endingCharacters);

        //09.Book Search
        //string stringSearched = Console.ReadLine();
        //result = GetBookTitlesContaining(db, stringSearched);

        //10.Book Search by Author
        //string stringSearched = Console.ReadLine();
        //result = GetBooksByAuthor(db, stringSearched);

        //11.Count Books
        //int length = int.Parse(Console.ReadLine());
        //int countBooks = CountBooks(db, length);
        //Console.WriteLine(countBooks);

        //12.Total Book Copies
        //result = CountCopiesByAuthor(db);

        //13.Profit by Category
        //result = GetTotalProfitByCategory(db);

        //14.Most Recent Books
        //result = GetMostRecentBooks(db);

        //15.Increase Prices
        //IncreasePrices(db);

        //16.Remove Books
        //int removedBooksCount = RemoveBooks(db);
        //Console.WriteLine(removedBooksCount);

        //Console.WriteLine(result); // <- Comment this when sumbitting exercises number 11, 15 and 16
    }

    //O2.Age Restriction
    public static string GetBooksByAgeRestriction(BookShopContext context, string command)
    {
        var enumValue = Enum.Parse<AgeRestriction>(command, true);

        //Finding the Books
        var books = context.Books
            .Where(b => b.AgeRestriction == enumValue)
            .Select(b => b.Title)
            .OrderBy(t => t)
            .ToArray();

        //Output
        return String.Join(Environment.NewLine, books);
    }

    //O3.Golden Books
    public static string GetGoldenBooks(BookShopContext context)
    {
        var editionType = Enum.Parse<EditionType>("Gold", false);

        //Finding the Books
        var goldenBooks = context.Books
            .Where(gb => gb.EditionType == editionType && gb.Copies < 5000)
            .Select(gb => new { gb.BookId, gb.Title })
            .OrderBy(gb => gb.BookId)
            .ToArray();

        //Output
        return String.Join(Environment.NewLine, goldenBooks.Select(gb => gb.Title));
    }

    //O4.Books by Price
    public static string GetBooksByPrice(BookShopContext context)
    {
        //Finding the Books
        var books = context.Books
            .Where(b => b.Price > 40)
            .Select(b => new { b.Title, b.Price })
            .OrderByDescending(b => b.Price)
            .ToArray();

        //Output
        StringBuilder sb = new StringBuilder();
        foreach (var book in books)
        {
            sb.AppendLine($"{book.Title} - ${book.Price:f2}");
        }
        return sb.ToString().TrimEnd();
    }

    //05.Not Released In
    public static string GetBooksNotReleasedIn(BookShopContext context, int year)
    {
        //Finding the Books
        var books = context.Books
            .Where(b => b.ReleaseDate.Value.Year != year)
            .Select(b => new { b.BookId, b.Title })
            .OrderBy(b => b.BookId)
            .ToArray();

        //Output
        return String.Join(Environment.NewLine, books.Select(b => b.Title));
    }

    //06.Book Titles By Category
    public static string GetBooksByCategory(BookShopContext context, string input)
    {
        string[] categories = input.ToLower().Split().ToArray();

        //Finding the Books
        var books = context.BooksCategories
            .Where(bc => categories.Contains(bc.Category.Name.ToLower()))
            .Select(bc => bc.Book.Title)
            .OrderBy(t => t)
            .ToArray();

        //Output
        return String.Join(Environment.NewLine, books);
    }

    //07.Released Before Date
    public static string GetBooksReleasedBefore(BookShopContext context, string date)
    {
        DateTime parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", null);

        //Finding the Books
        var books = context.Books
            .Where(b => b.ReleaseDate < parsedDate)
            .Select(b => new { b.Title, b.EditionType, b.Price, b.ReleaseDate })
            .OrderByDescending(b => b.ReleaseDate);

        //Output
        StringBuilder sb = new StringBuilder();
        foreach (var book in books)
        {
            sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
        }
        return sb.ToString().TrimEnd();
    }

    //08.Author Search
    public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
    {
        //Finding the Authors
        var authors = context.Authors
            .Where(a => a.FirstName.EndsWith(input))
            .Select(a => new { FullName = a.FirstName + " " + a.LastName })
            .OrderBy(a => a.FullName)
            .ToArray();

        //Output
        return String.Join(Environment.NewLine, authors.Select(a => a.FullName));
    }

    //09.Book Search
    public static string GetBookTitlesContaining(BookShopContext context, string input)
    {
        //Finding the Books
        var books = context.Books
            .Where(b => b.Title.ToLower().Contains(input.ToLower()))
            .Select(b => b.Title)
            .OrderBy(t => t)
            .ToArray();

        //Output
        return String.Join(Environment.NewLine, books);
    }

    //10. Book Search by Author
    public static string GetBooksByAuthor(BookShopContext context, string input)
    {
        //Finding the Books
        var books = context.Books
            .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
            .Select(b => new
            {
                b.Title,
                AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                b.BookId
            })
            .OrderBy(b => b.BookId)
            .ToArray();

        //Output
        StringBuilder sb = new StringBuilder();
        foreach (var book in books)
        {
            sb.AppendLine($"{book.Title} ({book.AuthorName})");
        }
        return sb.ToString().TrimEnd();
    }

    //11.Count Books
    public static int CountBooks(BookShopContext context, int lengthCheck)
    {
        int booksCount = context.Books
            .Where(b => b.Title.Length > lengthCheck)
            .Count();

        return booksCount;
    }

    //12.Total Book Copies
    public static string CountCopiesByAuthor(BookShopContext context)
    {
        //Get Book Copies
        var authorsInfo = context.Authors
            .AsNoTracking()
            .Select(a => new
            {
                FullName = a.FirstName + " " + a.LastName,
                BooksCopiesCount = a.Books.Sum(b => b.Copies)
            })
            .OrderByDescending(a => a.BooksCopiesCount)
            .ToList();

        //Output
        StringBuilder sb = new StringBuilder();
        foreach (var author in authorsInfo)
        {
            sb.AppendLine($"{author.FullName} - {author.BooksCopiesCount}");
        }
        return sb.ToString().TrimEnd();
    }

    //13.Profit by Category
    public static string GetTotalProfitByCategory(BookShopContext context)
    {
        //Selecting the Categories and their Profits
        var categoriesInfo = context.Categories
            .AsNoTracking()
            .Select(c => new
            {
                CategoryName = c.Name,
                Profit = c.CategoryBooks.Sum(bc => bc.Book.Copies * bc.Book.Price)
            })
            .OrderByDescending(c => c.Profit)
            .ThenBy(c => c.CategoryName);

        //Output
        StringBuilder sb = new StringBuilder();
        foreach (var category in categoriesInfo)
        {
            sb.AppendLine($"{category.CategoryName} ${category.Profit:f2}");
        }
        return sb.ToString().TrimEnd();
    }

    //14.Most Recent Books
    public static string GetMostRecentBooks(BookShopContext context)
    {
        var categoriesInfo = context.Categories
            .AsNoTracking()
            .Select(c => new
            {
                CategoryName = c.Name,
                Books = c.CategoryBooks.Select(cb => new
                {
                    BookName = cb.Book.Title,
                    ReleaseDate = cb.Book.ReleaseDate
                })
                .OrderByDescending(b => b.ReleaseDate)
                .Take(3)
                .ToArray()
            })
            .OrderBy(c => c.CategoryName)
            .ToArray();

        //Output
        StringBuilder sb = new StringBuilder();
        foreach (var category in categoriesInfo)
        {
            sb.AppendLine($"--{category.CategoryName}");

            foreach (var book in category.Books)
            {
                sb.AppendLine($"{book.BookName} ({book.ReleaseDate.Value.Year})");
            }
        }
        return sb.ToString().TrimEnd();
    }

    //15.Increase Prices
    public static void IncreasePrices(BookShopContext context)
    {
        var books = context.Books
            .Where(b => b.ReleaseDate.Value.Year < 2010)
            .ToArray();

        foreach (var book in books)
        {
            book.Price += 5;
        }

        context.SaveChanges();
    }

    //16.Remove Books
    public static int RemoveBooks(BookShopContext context)
    {
        //Finding the Books and CategoriesBooks that need to be deleted
        var booksCategoriesToRemove = context.BooksCategories
            .Where(bc => bc.Book.Copies < 4200)
            .ToArray();

        var booksToRemove = context.Books
            .Where(b => b.Copies < 4200)
            .ToArray();

        int removedBooks = booksToRemove.Count();

        //Removing and Saving the Changes
        context.BooksCategories.RemoveRange(booksCategoriesToRemove);
        context.Books.RemoveRange(booksToRemove);
        context.SaveChanges();

        //Output
        return removedBooks;
    }
}