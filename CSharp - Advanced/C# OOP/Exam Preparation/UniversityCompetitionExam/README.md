### Overview

The end of the last year in high school is approaching and the students will have to choose wisely their way to the future. Everyone will try to enter the best universities. You will be in the department, developing the governmental centralized ranking system. This system must have support for Subject, Student and University. The project will consist of model classes and a controller class, which manages the interaction between the subjects, students and universities.

### Setup

	Upload only the UniversityCompetition project in every task except Unit Tests.
	Do not modify the interfaces or their packages.
	Use strong cohesion and loose coupling.
	Use inheritance and the provided interfaces wherever possible.
  		This includes constructors, method parameters, and return types.
	Do not violate your interface implementations by adding more public methods in the concrete class than the interface has defined.
	Make sure you have no public fields anywhere.
	Exception messages and output messages can be found in the "Utilities" folder.
	For solving this problem use Visual Studio 2019, Visual Studio 2022 and netcoreapp 3.1

### Task 1: Structure (50 points)

For this task’s evaluation logic in the methods isn’t included.

You are given 4 interfaces, and you must implement their functionality in the correct classes.

There are 3 types of entities and 3 repositories in the application: Subject, Student, University and Repository (SubjectRepository, StudentRepository and UniversityRepository) for each of them:

## Subject

Subject is a base class for any type of Subject, and it should not be able to be instantiated.

### Data

	Id – int
		The Id property will take its value upon adding the entity to the SubjectRepository. Every new Subject will take the next consecutive number in the repository, starting from 1. The property will be set in the AddSubject method from the Controller class.

	Name - string
		If the name is null or whitespace, throw an ArgumentException with the message "Name cannot be null or whitespace!" 
		Rate – double
		The significance of the Subject.
		
	Rate – double
		The significance of the Subject.

