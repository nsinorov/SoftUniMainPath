
namespace ExplicitInterfaces.Model.Interfaces
{
    public interface IResident
    {
        public string Name { get; }
        public string Country { get; }

        public string GetName();
    }
}
