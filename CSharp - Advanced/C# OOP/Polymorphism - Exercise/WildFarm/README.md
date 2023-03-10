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
