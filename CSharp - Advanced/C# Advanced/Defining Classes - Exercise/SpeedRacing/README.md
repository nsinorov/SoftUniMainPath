Create a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class Car. Each Car has the following properties:

	string Model
	double FuelAmount
	double FuelConsumptionPerKilometer
	double Travelled distance

A car's model is unique - there will never be 2 cars with the same model. On the first line of the input, you will receive a number N – the number of cars you need to track. On each of the next N lines, you will receive information about a car in the following format: 
  
  	"{model} {fuelAmount} {fuelConsumptionFor1km}"

All cars start at 0 kilometers traveled. After the N lines, until the command "End" is received, you will receive commands in the following format: 

	"Drive {carModel} {amountOfKm}"
