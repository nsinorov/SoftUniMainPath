You are asked to model an application for storing data about people. You should be able to have a person and a child. The child derives from the person. Your task is to model the application. The only constraints are:

	People should not be able to have a negative age
	Children should not be able to have an age greater than 15.

	Person – represents the base class by which all of the others are implemented
	Child - represents a class, which derives from Person.
	
Note
Your class’s names MUST be the same as the names shown above!!!

Create a new empty class and name it Person. Set its access modifier to the public so it can be instantiated from any project. Every person has a name and an age.

	Define a field for each property the class should have (e.g. Name, Age) 
	Define the Name and Age properties of a Person. 

### Step 1 – Define a Constructor

Define a constructor that accepts name and age.

### Step 2 – Override ToString()

As you probably already know, all classes in C# inherit the Object class and therefore have all its public members (ToString(), Equals(), and GetHashCode() methods). ToString() serves to return information about an instance as а string. Let's override (change) its behavior for our Person class.
