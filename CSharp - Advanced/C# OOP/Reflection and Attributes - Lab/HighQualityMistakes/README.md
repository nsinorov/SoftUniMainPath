NOTE: You need a public StartUp class with the namespace Stealer.

You are already an expert on High-Quality Code, so you know what kind of access modifiers must be set to the members of a class. You should have noticed that our hacker is not familiar with these concepts.

Create a method inside your Spy class called - AnalyzeAccessModifiers(string className). Check all of the fields and methods access modifiers. Print on the console all of the mistakes in the format:

	Fields
  
   	{fieldName} must be private!
    
	Getters
  
  	{methodName} have to be public!
    
	Setters 
  
  	{methodName} have to be private!

Use StringBuilder to concatenate the answer. Don’t change anything in Hacker class!

In your Main() method you should be able to check your program with the current piece of code.

### Example:

NOTE: The order of your output may differ based on your solution logic.

![image](https://user-images.githubusercontent.com/45227327/226309302-5ca83ae2-d773-4f0f-9079-d1fc82278d84.png)
