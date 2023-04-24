
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EDriveRent.Repositories;

public class UserRepository : IRepository<IUser>
{
    private readonly List<IUser> users;
    public UserRepository()
    {
        users = new List<IUser>();
    }
    public void AddModel(IUser model) => users.Add(model);

    public IUser FindById(string identifier)
    {
        return users.FirstOrDefault(m => m.DrivingLicenseNumber == identifier);
    }

    public IReadOnlyCollection<IUser> GetAll() => users;

    public bool RemoveById(string identifier)
    {
        IUser user = users.FirstOrDefault(r => r.DrivingLicenseNumber == identifier);

        if (user == null)
        {
          
            return false;
        }
        users.Remove(user);
        return true;
    }
}
