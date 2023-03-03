A pizza is made of dough and different toppings. You should model a class Pizza, which should have a name, dough, and toppings as fields. Every type of ingredient should have its class. Every ingredient has different properties: the dough can be white or wholegrain and in addition, it can be crispy, chewy, or homemade.
The topping can be of type meat, veggies, cheese, or sauce.
Every ingredient should weigh grams and a method for calculating its calories according to its type. Calories per gram are calculated through modifiers.
Every ingredient has 2 calories per gram as a base and a modifier that gives the exact calories. For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough, weighing 100 grams will have 2 * 100 * 1.5 * 1.1 = 330.00 total calories.

Your job is to model the classes in such a way that they are properly encapsulated and to provide a public method for every pizza that calculates its calories according to the ingredients it has. 

### Step 1. Create a Dough Class

The base ingredient of a Pizza is the dough. First, you need to create a class for it. It has a flour type, which can be white or wholegrain. In addition, it has a baking technique, which can be crispy, chewy, or homemade. The dough should weigh grams. The calories per gram of dough are calculated depending on the flour type and the baking technique. Every dough has 2 calories per gram as a base and a modifier that gives the exact calories. For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough, weighing 100 grams will have (2 * 100) * 1.5 * 1.1 = 330.00 total calories. You are given the modifiers below:
Modifiers:	

	White - 1.5
	Wholegrain - 1.0
	Crispy - 0.9
	Chewy - 1.1
	Homemade - 1.0

Everything that the class should expose is a getter for the calories per gram. Your task is to create the class with a proper constructor, fields, getters, and setters. Make sure you use the proper access modifiers.

### Step 2. Validate Data for the Dough Class

Change the internal logic of the Dough class by adding a data validation in the setters.

Make sure that if an invalid flour type or an invalid baking technique is given a proper Exception is thrown with the message "Invalid type of dough.".

The allowed weight of dough is in the range [1..200] grams. If it is outside of this range throw an Exception with the message "Dough weight should be in the range [1..200].".
