namespace Student_Information
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           
           string name = Console.ReadLine();    
           int age = int.Parse(Console.ReadLine());
           double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
        }
    }
}
