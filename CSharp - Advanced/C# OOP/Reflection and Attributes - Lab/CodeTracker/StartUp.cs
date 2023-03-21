using AuthorProblem;
using System.Diagnostics;

namespace AutorProblem;

[Author("Victor")]
class StartUp
{
    [Author("George")]
    public static void Main(string[] args)
    {
        var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
}