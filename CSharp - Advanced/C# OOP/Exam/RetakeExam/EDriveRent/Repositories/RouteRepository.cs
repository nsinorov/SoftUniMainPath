using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EDriveRent.Repositories;
public class RouteRepository : IRepository<IRoute>
{
    private readonly List<IRoute> routes;
    public RouteRepository()
    {
        routes = new List<IRoute>();
    }
    public void AddModel(IRoute model) => routes.Add(model);

    public IRoute FindById(string identifier)
    {
        return routes.FirstOrDefault(u => u.RouteId == int.Parse(identifier));
    }

    public IReadOnlyCollection<IRoute> GetAll() => routes;

    public bool RemoveById(string identifier)
    {
        IRoute route = routes.FirstOrDefault(r => r.RouteId == int.Parse(identifier));

        if (route == null)
        {        
            return false;
        }

        routes.Remove(route);
        return false;
    }
}
