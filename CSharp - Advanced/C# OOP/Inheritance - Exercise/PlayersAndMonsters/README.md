NOTE: You need a public class StartUp.

Your task is to create the following game hierarchy: 

![image](https://user-images.githubusercontent.com/45227327/221373722-9b475bf5-eae9-4cf4-afc2-595e646e73a6.png)

Create a class Hero. It should contain the following members:

	A constructor, which accepts:
    		username – string
    		level – int
	The following properties:
		Username - string
		Level – int
	ToString() method

Hint: Override ToString() of the base class in the following way:

public override string ToString():

	{
  	  return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
	}

### Examples:

![image](https://user-images.githubusercontent.com/45227327/221373812-52945bd9-c1c5-4f88-8949-ce8cbffb7d00.png)
