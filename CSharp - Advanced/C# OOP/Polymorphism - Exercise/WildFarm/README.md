Your task is to create a class hierarchy like the one described below. The Animal, Bird, Mammal, Feline, and Food classes should be abstract. Override the method ToString().

	Food – int Quantity
  	Vegetable
  	Fruit
  	Meat
	  Seeds
    
	Animal – string Name, double Weight, int FoodEaten
	  Bird – double WingSize
    	Owl
    	Hen
  	Mammal – string LivingRegion
    	Mouse
	    Dog
	    Feline – string Breed
	      Cat
	      Tiger

All animals should also have the ability to ask for food by producing a sound:

	Owl – "Hoot Hoot"
	Hen – "Cluck"
	Mouse – "Squeak"
	Dog – "Woof!"
	Cat – "Meow"
	Tiger – "ROAR!!!"

Now use the classes that you have created to instantiate some animals and feed them.
Input should be read from the console. Every even line (starting from 0) will contain information about an animal in the following format:

	Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}"
	Birds - "{Type} {Name} {Weight} {WingSize}"
	Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}"

On the odd lines, you will receive information about a piece of food that you should give to that animal. The line will consist of a FoodType and quantity, separated by whitespace.

Animals will only eat a certain type of food, as follows:

	Hens eat everything
	Mice eat vegetables and fruits
	Cats eat vegetables and meat
	Tigers, Dogs, and Owls eat only meat

If you try to give an animal a different type of food, it will not eat it and you should print:

	"{AnimalType} does not eat {FoodType}!"
	
The weight of an animal will increase with every piece of food it eats, as follows:

	Hen - 0.35
	Owl - 0.25
	Mouse - 0.10
	Cat - 0.30
	Dog - 0.40
	Tiger - 1.00
	
Override the ToString() method to print the information about an animal in the formats:

	Birds - "{AnimalType} [{AnimalName}, {WingSize}, {AnimalWeight}, {FoodEaten}]"
	Felines - "{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"
	Mice and Dogs - "{AnimalType} [{AnimalName}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"

After you have read the information about the animal and the food, the animal will produce a sound (print it on the console). Next, you should try to feed it. After receiving the "End" command, print information about every animal in order of input.

### Example:

![image](https://user-images.githubusercontent.com/45227327/224399665-a767b5ea-1468-4c49-89d6-9903323e732f.png)
