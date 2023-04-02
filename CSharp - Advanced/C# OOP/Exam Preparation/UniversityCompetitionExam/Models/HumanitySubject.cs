
namespace UniversityCompetition.Models;

public class HumanitySubject : Subject
{
    private const double subjectsRate = 1.15;
    public HumanitySubject(int subjectId, string subjectName) : base(subjectId, subjectName, subjectsRate)
    {

    }
}
