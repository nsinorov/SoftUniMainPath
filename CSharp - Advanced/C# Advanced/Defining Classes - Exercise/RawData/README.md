Create a program that tracks cars and their cargo. 

Start by defining a class Car that holds information about:

	Model: a string property
	Engine: a class with two properties – speed and power,
	Cargo: a class with two properties – type and weight 
	Tires: a collection of exactly 4 tires. Each tire should have two properties: age and pressure.

Create a constructor that receives all of the information about the Car and creates and initializes the model and its inner components (engine, cargo and tires).

## Input:

On the first line of input, you will receive a number N representing the number of cars you have. 

**1.** On the next N lines, you will receive information about each car in the format:
	
		"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
	
-The speed, power, weight and tire age are integers.

-The tire pressure is a floating point number. 

**2.** Next, you will receive a single line with one of the following commands:  "fragile" or "flammable".

## Output:

	"fragile" - print all cars, whose cargo is "fragile" and have a pressure of a single tire < 1.
	"flammable" - print all cars, whose cargo is "flammable" and have engine power > 250.
	
The cars should be printed in order of appearing in the input.

## Examples:

![image](https://user-images.githubusercontent.com/45227327/216831149-60c7b81f-b148-4cff-a07f-9af2e2baecc4.png)
![image](https://user-images.githubusercontent.com/45227327/216831159-921f7119-1a80-49ec-8e8e-79f32da74f79.png)
