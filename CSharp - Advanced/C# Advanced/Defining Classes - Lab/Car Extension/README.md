NOTE: You need a StartUp class with the namespace CarManufacturer.

Create a class Car (you can use the class from the previous task).

The class should have private fields for:

	make: string
	model: string
	year: int
	fuelQuantity: double
	fuelConsumption: double

The class should also have properties for:

	Make: string
	Model: string
	Year: int
	FuelQuantity: double
	FuelConsumption: double

The class should also have methods for:

	Drive(double distance): void – This method checks if the car fuel quantity minus the distance multiplied by the car fuel consumption is bigger than zero. If it is removed from the fuel quantity, the result of the multiplication between the distance and the fuel consumption. Otherwise, write on the console the following message:  
      "Not enough fuel to perform this trip!".
      
	WhoAmI(): string – returns the following message: 
      "Make: {this.Make}
       Model: {this.Model}
       Year: {this.Year}
       Fuel: {this.FuelQuantity:F2}"
       
You should be able to use the class like this:

![image](https://user-images.githubusercontent.com/45227327/216152330-08c3188a-4b6f-49b3-9e63-2788e0b6ebc2.png)
