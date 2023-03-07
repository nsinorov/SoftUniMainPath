Create a program that models 2 vehicles (a Car and a Truck) and simulates driving and refueling them.

Car and truck both have fuel quantity, fuel consumption in liters per km, and can be driven a given distance and refueled with a given amount of fuel. It's summer, so both vehicles use air conditioners and their fuel consumption per km is increased by 0.9 liters for the car and with 1.6 liters for the truck.

Also, the truck has a tiny hole in its tank and when it’s refueled it keeps only 95% of the given fuel. The car has no problems and adds all the given fuel to its tank. If a vehicle cannot travel the given distance, its fuel does not change.

### Input:

	On the first line – information about the car in the format: "Car {fuel quantity} {liters per km}"
	On the second line – info about the truck in the format: "Truck {fuel quantity} {liters per km}"
	On the third line – the number of commands N that will be given on the next N lines
	On the next N lines – commands in the format:
