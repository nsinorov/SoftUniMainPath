
using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Text;

namespace EDriveRent.Models;

public abstract class Vehicle : IVehicle
{
    private string brand;
    private string model;
    private string licensePlateNumber;
    private double maxMileage;
    private int batteryLevel;
    private bool isDamaged;

    public Vehicle(string brand, string model, double maxMileage, string licensePlateNumber)
    {
        Brand = brand;
        Model = model;
        MaxMileage = maxMileage;
        LicensePlateNumber = licensePlateNumber;
        BatteryLevel = 100;
        IsDamaged = false;
    }
    public string Brand
    {
        get => brand;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.BrandNull);
            }

            brand = value;
        }
    }
    public string Model
    {
        get => model;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.ModelNull);
            }

            model = value;
        }
    }

    public double MaxMileage
    {
        get => maxMileage;
        private set { maxMileage = value; }
    }

    public string LicensePlateNumber
    {
        get => licensePlateNumber;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.LicenceNumberRequired);
            }

            licensePlateNumber = value;
        }
    }

    public int BatteryLevel
    {
        get => batteryLevel;
        private set
        {
            value = batteryLevel;
        }
    }

    public bool IsDamaged
    {
        get => isDamaged;
        private set
        {
            isDamaged = value;
        }
    }

    public void Drive(double mileage)
    {
       
        int passedMaxMileage = (int)Math.Round((mileage / this.MaxMileage) * 100);

        this.BatteryLevel -= passedMaxMileage;

        if (MaxMileage == 180)
        {
            BatteryLevel -= 5;
        }
    }
    public void ChangeStatus()
    {
        if (IsDamaged)
        {
            IsDamaged = false;
        }

        else if (!IsDamaged)
        {
            IsDamaged = true;
        }
    }

    public void Recharge()
    {
        BatteryLevel = 100;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append($"{this.Brand} {this.Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: ");

        if (IsDamaged)
        {
            sb.Append("damaged");
        }
        else
        {
            sb.Append("OK");
        }

        return sb.ToString().TrimEnd();
    }
}
