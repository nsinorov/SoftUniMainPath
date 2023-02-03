using DefiningClasses;
using System;
using System.Collections.Immutable;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Person> peopleOver30 = new();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] personProperties = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Person person = new(personProperties[0], int.Parse(personProperties[1]));

            if (person.Age > 30)
            {
                peopleOver30.Add(person);
            }
        }
        foreach (var people in peopleOver30.OrderBy(p => p.Name))
        {
            Console.WriteLine($"{people.Name} - {people.Age}");
        }
    }
}