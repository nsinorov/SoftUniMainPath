
using EDriveRent.Core.Contracts;
using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories;
using EDriveRent.Repositories.Contracts;
using EDriveRent.Utilities.Messages;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;

namespace EDriveRent.Core;

public class Controller : IController
{
    private UserRepository users;
    private VehicleRepository vehicles;
    private RouteRepository routes;

    public Controller()
    {
        users = new UserRepository();
        vehicles = new VehicleRepository();
        routes = new RouteRepository();
    }

    public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
    {
        IUser user = users.FindById(drivingLicenseNumber);

        if (user != null)
        {
            return string.Format(OutputMessages.UserWithSameLicenseAlreadyAdded, drivingLicenseNumber);
        }

        user = new User(firstName, lastName, drivingLicenseNumber);

        users.AddModel(user);

        return string.Format(OutputMessages.UserSuccessfullyAdded, firstName, lastName, drivingLicenseNumber);
    }

    public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
    {
        if (vehicleType != nameof(PassengerCar)
                && vehicleType != nameof(CargoVan))
        {
            return string.Format(OutputMessages.VehicleTypeNotAccessible, vehicleType);
        }

        IVehicle vehicle = vehicles.FindById(licensePlateNumber);

        if (vehicleType == nameof(PassengerCar))
        {
            vehicle = new PassengerCar(brand, model, licensePlateNumber);
        }
        if (vehicleType == nameof(CargoVan))
        {
            vehicle = new CargoVan(brand, model, licensePlateNumber);
        }
        vehicles.AddModel(vehicle);

        return string.Format(OutputMessages.VehicleAddedSuccessfully, brand, model, licensePlateNumber);
    }

    public string AllowRoute(string startPoint, string endPoint, double length)
    {
        IRoute route = routes.GetAll().Where(r => r.StartPoint == startPoint && r.EndPoint == endPoint
             && r.Length == length).FirstOrDefault();

        if (route != null)
        {
            return string.Format(OutputMessages.RouteExisting, startPoint, endPoint, length);
        }

        route = routes.GetAll().Where(r => r.StartPoint == startPoint && r.EndPoint == endPoint
        && r.Length < length).FirstOrDefault();

        if (route != null)
        {
            return string.Format(OutputMessages.RouteIsTooLong, startPoint, endPoint);
        }

        int routedId = routes.GetAll().Count + 1;

        route = new Route(startPoint, endPoint, length, routedId);

        routes.AddModel(route);

        if (routes.GetAll().Where(r => r.StartPoint == startPoint && r.EndPoint == endPoint
        && r.Length > length).FirstOrDefault() != null)
        {
            routes.GetAll().Where(r => r.StartPoint == startPoint && r.EndPoint == endPoint
        && r.Length > length).FirstOrDefault().LockRoute();
        }

        return string.Format(OutputMessages.NewRouteAdded, startPoint, endPoint, length);
    }

    public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
    {
        IUser user = users.FindById(drivingLicenseNumber);

        if (user.IsBlocked)
        {
            return string.Format(OutputMessages.UserBlocked, drivingLicenseNumber);
        }

        IVehicle vehicle = vehicles.FindById(licensePlateNumber);

        if (vehicle.IsDamaged)
        {
            return string.Format(OutputMessages.VehicleDamaged, licensePlateNumber);
        }

        IRoute route = routes.FindById(routeId);

        if (route.IsLocked)
        {
            return string.Format(OutputMessages.RouteLocked, routeId);
        }

        vehicle.Drive(route.Length);

        if (isAccidentHappened)
        {
            if (vehicle.IsDamaged == false)
            {
                vehicle.ChangeStatus();
            }
            user.DecreaseRating();
        }
        else
        {
            user.IncreaseRating();
        }

        return vehicle.ToString();
    }

    public string RepairVehicles(int count)
    {
        List<IVehicle> vehiclesList = vehicles
                .GetAll()
                .Where(v => v.IsDamaged == true)
                .OrderBy(x => x.Brand)
                .ThenBy(x => x.Model)
                .ToList();

        int vehiclesCount = vehiclesList.Count;

        vehiclesList = vehiclesList.Take(Math.Min(count, vehiclesCount)).ToList();

        foreach (var vehicle in vehiclesList)
        {
            vehicle.ChangeStatus();
            vehicle.Recharge();
        }
        return string.Format(OutputMessages.RepairedVehicles, vehiclesList.Count);
    }

    public string UsersReport()
    {
        StringBuilder sb = new();

        List<IUser> usersList = users.GetAll()
            .OrderByDescending(u => u.Rating)
                .ThenBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .ToList();

        sb.AppendLine($"*** E-Drive-Rent ***");

        foreach (var user in usersList)
        {
            sb.AppendLine(user.ToString());
        }

        return sb.ToString().TrimEnd();
    }
}
