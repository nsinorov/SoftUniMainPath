using System.Globalization;

int numOfStudents = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

for (int i = 0; i < numOfStudents; i++)
{
    string[] input = Console.ReadLine().Split();
    string studentName = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (!students.ContainsKey(studentName))
    {
        students.Add(studentName, new List<decimal>());
    }

    students[studentName].Add(grade);

}

foreach (var studentGrade in students)
{
    Console.WriteLine($"{studentGrade.Key} -> {string.Join(" ", studentGrade.Value.Select(x => $"{x:F2}").ToList())} (avg: {studentGrade.Value.Average():F2})");
}