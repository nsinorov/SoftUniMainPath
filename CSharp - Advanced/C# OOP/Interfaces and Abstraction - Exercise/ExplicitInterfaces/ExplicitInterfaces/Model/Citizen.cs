
using ExplicitInterfaces.Model.Interfaces;

namespace ExplicitInterfaces.Model
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        public string Name { get; private set; }

        public string Country { get; private set; }

        public int Age { get; private set; }

        string IResident.GetName() => $"Mr/Ms/Mrs {Name}";
        string IPerson.GetName() => Name;
    }
}
