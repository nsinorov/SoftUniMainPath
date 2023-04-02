
namespace UniversityCompetition.Models;

public class TechnicalSubject : Subject
{
    private const double subjectsRate = 1.3;
    public TechnicalSubject(int subjectId, string subjectName) : base(subjectId, subjectName, subjectsRate)
    {

    }
}
