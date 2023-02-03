Define two classes Car and Engine. 

Start by defining a class Car that holds information about:

	Model: a string property
	Engine: a property holding the engine object
	Weight: an int property, it is optional
	Color: a string property, it is optional

Next, the Engine class has the following properties:

	Model: a string property
	Power: an int property
	Displacement: an int property, it is optional
	Efficiency: a string property, it is optional

## Input:

1.On the first line, you will read a number N, which will specify how many lines of engines you will receive. 

	On each of the next N lines, you will receive information about an Engine in the following format: "{model} {power} {displacement} {efficiency}"
	Keep in mind that "displacement" and "efficiency" are optional, they could be missing from the command.

2.Next, you will receive a number M, which will specify how many lines of car you will receive. 

	On each of the next M lines, you will receive information about a Car in the following format: "{model} {engine} {weight} {color}".
	Keep in mind that "weight" and "color" are optional, they could be missing from the command.
	The "engine" will always be the model of an existing Engine.
	When creating the object for a Car, you should keep a reference to the real engine in it, instead of just the engine's model. 

Note: The optional properties might be missing from the formats.
