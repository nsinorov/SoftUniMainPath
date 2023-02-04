Your task is to create a repository, which stores cars by creating the classes described below.

First, write a C# class Car with the following properties:

	Make: string
	Model: string
	HorsePower: int
	RegistrationNumber: string

The class' constructor should receive make, model, horsePower and registrationNumber and override the ToString() method in the following format:

	"Make: {make}"
	"Model: {model}"
	"HorsePower: {horse power}"
	"RegistrationNumber: {registration number}"
	
Create a C# class Parking that has Cars (a collection that stores the entity Car). All entities inside the class have the same properties.

The class' constructor should initialize the Cars with a new instance of the collection and accept capacity as a parameter. 

Implement the following fields:

	Field cars –  a collection that holds added cars.
	Field capacity – accessed only by the base class (responsible for the parking capacity).

Implement the following methods:

	AddCar(Car Car)
	RemoveCar(string RegistrationNumber)
	GetCar(string RegistrationNumber)
	RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
	
## Examples:

![image](https://user-images.githubusercontent.com/45227327/216777375-a2575c46-9f76-4ab3-a432-954f30968d5c.png)
