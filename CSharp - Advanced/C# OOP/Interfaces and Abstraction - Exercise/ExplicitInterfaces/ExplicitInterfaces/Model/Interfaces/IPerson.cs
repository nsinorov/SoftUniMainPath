
namespace ExplicitInterfaces.Model.Interfaces
{
    public interface IPerson
    {
        public string Name { get; }
        public int Age { get; }

        string GetName();
    }
}
