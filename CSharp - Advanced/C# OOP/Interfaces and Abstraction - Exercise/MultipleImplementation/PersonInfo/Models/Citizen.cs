using PersonInfo.Models.Interfaces;

namespace PersonInfo.Models
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public string Birthdate { get; }
    }
}
