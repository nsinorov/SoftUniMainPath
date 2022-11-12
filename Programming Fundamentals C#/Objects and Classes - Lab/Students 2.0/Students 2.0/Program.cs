using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] personInfo = input.Split();

                string firstName = personInfo[0];
                string lastName = personInfo[1];
                int age = int.Parse(personInfo[2]);
                string town = personInfo[3];

                Student student = new Student(firstName, lastName, age, town);

                bool exists = false;

               foreach(var currStudent in students)
                {
                    if(currStudent.FirstName == student.FirstName && currStudent.LastName == student.LastName)
                    {
                        currStudent.Age = student.Age;
                        currStudent.HomeTown = student.HomeTown;
                        exists = true;
                    }
                }

                if (!exists)
                {
                    students.Add(student);
                }
              

                input = Console.ReadLine();
            }

            string desiredTown = Console.ReadLine();

            foreach (var currStudent in students)
            {
                if (currStudent.HomeTown == desiredTown)
                {
                    Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old. ");
                }
            }
        }
    }

    public class Student
    {

        public Student(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = town;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }


    }
}