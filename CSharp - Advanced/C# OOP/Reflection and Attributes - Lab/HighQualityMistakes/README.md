NOTE: You need a public StartUp class with the namespace Stealer.

You are already an expert on High-Quality Code, so you know what kind of access modifiers must be set to the members of a class. You should have noticed that our hacker is not familiar with these concepts.

Create a method inside your Spy class called - AnalyzeAccessModifiers(string className). Check all of the fields and methods access modifiers. Print on the console all of the mistakes in the format:

	Fields
  
   	{fieldName} must be private!
    
	Getters
  
  	{methodName} have to be public!
    
	Setters 
  
  	{methodName} have to be private!
