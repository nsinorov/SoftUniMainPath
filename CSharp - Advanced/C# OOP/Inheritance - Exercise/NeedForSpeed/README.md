NOTE: You need a public class StartUp. Create the following hierarchy with the following classes: 

![image](https://user-images.githubusercontent.com/45227327/221422475-de1c475f-810c-4a3c-9824-b055f4e03b75.png)

Create a base class Vehicle. It should contain the following members:

	A constructor that accepts the following parameters: int horsePower, double fuel
	DefaultFuelConsumption – double 
	FuelConsumption – virtual double
	Fuel – double
	HorsePower – int
	virtual void Drive(double kilometers)
	  The Drive method should have a functionality to reduce the Fuel based on the traveled kilometers.

The default fuel consumption for Vehicle is 1.25. Some of the classes have different default fuel consumption values:

	SportCar – DefaultFuelConsumption = 10
	RaceMotorcycle – DefaultFuelConsumption = 8
	Car – DefaultFuelConsumption = 3

### Examples: 

