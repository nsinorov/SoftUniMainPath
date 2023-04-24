# Overview

You are chosen to take part in a Start-up company, which is developing an electric vehicles rent-a-car application. Your task is to create the classes needed for the application and implement the logic, standing behind some important buttons. The application must have support for User, Vehicle and Route. The project will consist of model classes and a controller class, which manages the interaction between the users, vehicles and routes.

# Setup

	Upload only the EDriveRent project in every task except Unit Tests.
	Do not modify the interfaces or their packages.
	Use strong cohesion and loose coupling.
	Use inheritance and the provided interfaces wherever possible.
  	This includes constructors, method parameters, and return types.
	Do not violate your interface implementations by adding more public methods in the concrete class than the interface has defined.
	Make sure you have no public fields anywhere.
	Exception messages and output messages can be found in the "Utilities" folder.
	For solving this problem use Visual Studio 2019/ Visual Studio 2022 and netcoreapp 3.1/netcoreapp6.0

# Task 1: Structure (50 points)

For this task’s evaluation logic in the methods isn’t included.

You are given 4 interfaces (IUser, IVehicle, IRoute and IRepository) and you must implement their functionality in the correct classes.

There should be 3 types of entities and 3 repositories in the application: User, Vehicle, Route and Repository (UserRepository, VehicleRepository and RouteRepository) for each of them:

## User

## Data

	FirstName – string
		If the FirstName is null or whitespace, throw an ArgumentException with the message "FirstName cannot be null or whitespace!" 
		
	LastName - string
		If the LastName is null or whitespace, throw an ArgumentException with the message 
		"LastName cannot be null or whitespace!" 
		
	DrivingLicenseNumber – string
		If the DrivingLicenseNumber is null or whitespace, throw an ArgumentException with the message "Driving license number is required!"
		
	Rating – double
		Set Rating’s initial value to zero. The value of the Rating will be changed every time a User drives a Vehicle. Remember to keep the setter private.
		
	IsBlocked – bool
		Set IsBloked’s initial value to false.

## Behavior

### void IncreaseRating()

Еvery time a User rents a Vehicle and completes the trip without any accidents, his Rating will increase by 0.5:

	If the Rating’s value exeeds 10.0, set the value to 10.0.

### void DecreaseRating()

	Еvery time a User rents a Vehicle and completes the trip with an accident, his Rating will decrease by 2.0:

	If the Rating’s value drops below 0.0, set the Rating’s value to 0.0 and IsBlocked’s value to true.

### Override ToString() method:

Override the existing method ToString() and modify it, so the returned string must be in the following format:

	"{FirstName} {LastName} Driving license: {drivingLicenseNumber} Rating: {rating}"
	
### Constructor

	A User should take the following values upon initialization:
	string firstName, string lastName, string drivingLicenceNumber

## Vehicle

Vehicle is a base class for any type of Vehicle, and it should not be able to be instantiated.

## Data

	Brand – string
		If the Brand is null or whitespace, throw an ArgumentException with the message "Brand cannot be null or whitespace!"
		
	Model - string
		If the Model is null or whitespace, throw an ArgumentException with the message "Model cannot be null or whitespace!"
	
	MaxMilеage - double
	
	LicensePlateNumber – string
	If the LicensePlateNumber is null or whitespace, throw an ArgumentException with the message "License plate number is required!"
	
	BatteryLevel – int
		Set BatteryLevel’s initial value to 100. This would be 100%. The value of the BatteryLevel will be changed every time a User drives a Vehicle or the Vehicle is being recharged. Remember to keep the setter private.
		
	IsDamaged – bool
		Set IsDamaged’s initial value to false.

## Behavior

### void Drive(double mileage)

	The Drive() method should reduce the BatteryLevel by a certain percentage. It should be calculated what part of the MaxMileage will be passed (for example: if the given mileage is 90 kilometers and the Vehicle’s MaxMileage is 180 kilometers, then you should reduce BatteryLevel by 50%). Also when driving CargoVan you should reduce additional 5%, because of the load.  The percentage should be rounded to the closest integer number. 

	Note: The Vehicle will always have enough battery to finish the trip.
	
### void Recharge()

	This method restores the value of the property BatteryLevel to 100%.
	
### void ChangeStatus()

This method sets value of the property IsDamaged. 

	If the value is false, set it to true
	Else set it to false.
	
### Override ToString() method:

Override the existing method ToString() and modify it, so the returned string must be in the following format:

	"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: OK/damaged"

### Constructor

A Vehicle should take the following values upon initialization:

	string brand, string model, double maxMileage, string licensePlateNumber
