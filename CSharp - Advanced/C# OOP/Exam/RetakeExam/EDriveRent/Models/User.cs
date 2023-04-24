
using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;

namespace EDriveRent.Models;

public class User : IUser
{
    private string firstName;
    private string lastName;
    private string drivingLicenseNumber;
    private double rating;
    private bool isBlocked;

    public User(string firstName, string lastName, string drivingLicenceNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        DrivingLicenseNumber = drivingLicenceNumber;
        Rating = 0;
        IsBlocked = false;
    }
    public string FirstName
    {
        get => firstName;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.FirstNameNull);
            }

            firstName = value;
        }
    }
    public string LastName
    {
        get => lastName;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.LastNameNull);
            }

            lastName = value;
        }
    }

    public string DrivingLicenseNumber
    {
        get => drivingLicenseNumber;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.DrivingLicenseRequired);
            }

            drivingLicenseNumber = value;
        }
    }

    public double Rating
    {
        get => rating;
        private set
        {
            rating = value;
        }
    }

    public bool IsBlocked
    {
        get { return isBlocked; }
        private set
        {
            isBlocked = value;
        }
    }
    public void IncreaseRating()
    {
        this.Rating += 0.5;
        if (this.Rating > 10)
        {
            this.Rating = 10;
        }
    }
    public void DecreaseRating()
    {
        this.Rating -= 2;
        if (this.Rating < 0)
        {
            this.Rating = 0;
            IsBlocked = true;
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} Driving license: {drivingLicenseNumber} Rating: {Rating}";
    }
}
