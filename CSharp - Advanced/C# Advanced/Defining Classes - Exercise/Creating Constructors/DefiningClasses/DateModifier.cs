
namespace DefiningClasses;

public class DateModifier
{
    public static int GetDiffInDays(string start, string end)
    {
        DateTime startDate = DateTime.Parse(start);
        DateTime endDate = DateTime.Parse(end);

        TimeSpan difference = endDate - startDate;

        return Math.Abs(difference.Days);
    }
}
