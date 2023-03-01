You need a public class StartUp.Create a hierarchy of Animals. Your program should have three different animals – Dog, Frog, and Cat. Deeper in the hierarchy you should have two additional classes – Kitten and Tomcat.

Kittens are female and Tomcats are male. All types of animals should be able to produce some kind of sound - ProduceSound().
For example, the dog should be able to bark. Your task is to model the hierarchy and test its functionality. Create an animal of each kind and make them all produce sound.

### Output:

	Print the information for each animal on three lines. On the first line, print: "{AnimalType}"
	On the second line print: "{Name} {Age} {Gender}"
	On the third line print the sounds it produces: "{ProduceSound()}"

### Constraints

	Each Animal should have a name, an age, and a gender
	All input values should not be blank (e.g. name, age, and so on…)
	If you receive an input for the gender of a Tomcat or a Kitten, ignore it but create the animal
	If the input is invalid for one of the properties, throw an exception with the message: "Invalid input!"
	Each animal should have the functionality to ProduceSound()
	Here is the type of sound each animal should produce:
		Dog: "Woof!"
		Cat: "Meow meow"
		Frog: "Ribbit"
		Kittens: "Meow"
		Tomcat: "MEOW"

### Examples:

![image](https://user-images.githubusercontent.com/45227327/222148401-71c1a50a-06ba-4444-bc94-9494d81d5e87.png)
