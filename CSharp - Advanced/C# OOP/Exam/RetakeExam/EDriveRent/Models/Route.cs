using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;

namespace EDriveRent.Models;
public class Route : IRoute
{
    public Route(string startPoint, string endPoint, double length, int routeId)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
        Length = length;
        RouteId = routeId;

        IsLocked = false;

    }
    private string startPoint;
    public string StartPoint
    {
        get => startPoint;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.StartPointNull));
            }
            startPoint = value;
        }
    }
    private string endPoint;
    public string EndPoint
    {
        get => endPoint;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.EndPointNull));
            }
            endPoint = value;
        }
    }
    private double length;
    public double Length
    {
        get => length;
        private set
        {
            if (value < 1)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RouteLengthLessThanOne));
            }
            length = value;
        }
    }
    private int routeId;
    public int RouteId
    {
        get { return routeId; }
        private set { routeId = value; }
    }

    private bool isLocked;
    public bool IsLocked
    {
        get { return isLocked; }
        private set { isLocked = value; }
    }

    public void LockRoute()
    {
        this.IsLocked = true;
    }
}
