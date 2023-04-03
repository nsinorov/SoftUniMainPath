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

## Constructor

A Subject should take the following values upon initialization:

	int subjectId, string subjectName, double subjectRate

## Child Classes

There are three concrete types of Subject:

### TechnicalSubject

	TechnicalSubject has a constant value for subjectRate = 1.3
	The constructor of the TechnicalSubject should take the following parameters upon initialization:
	int subjectId, string subjectName 

### EconomicalSubject

	EconomicalSubject has a constant value for subjectRate = 1.0

The constructor of the EconomicalSubject should take the following parameters upon initialization:

	int subjectId, string subjectName 

### HumanitySubject

	HumanitySubject has a constant value for subjectRate = 1.15
	The constructor of the HumanitySubject should take the following parameters upon initialization:
	int subjectId, string subjectName 

## Student

### Data

	Id – int
		The Id property will take its value upon adding the entity to the StudentRepository. Every new Student will take the next consecutive number in the repository, starting from 1. The property will be set in the AddStudent method from the Controller class.
		
	FirstName - string
		If the name is null or whitespace, throw an ArgumentException with the message "Name cannot be null or whitespace!"
		
	LastName - string
		If the name is null or whitespace, throw an ArgumentException with the message "Name cannot be null or whitespace!"
		
	CoveredExams – IreadOnlyCollection<int> - A collection of integer values, representing the subject ids of all covered exams by the student.
	
	University – IUniversity – The University where the student managed to join, after covering all the required exams.

## Behavior

### void CoverExam(ISubject subject)

	Takes the subject’s id and adds it to the collection of CoveredExams

### void JoinUniversity(IUniversity university)

	This method sets value of the property University.

### Constructor

A Student should take the following values upon initialization:

	int studentId, string firstName, string lastName 

## University

### Data

	Id – int
		The Id property will take its value upon adding the entity to the UniversityRepository. Every new University will take the next consecutive number in the repository, starting from 1. The property will be set in the AddUniversity method from the Controller class.
		
	Name - string
		If the name is null or whitespace, throw an ArgumentException with the message "Name cannot be null or whitespace!"
		
	Category – string available categories are: Technical, Economical, Humanity
		If the value does not match the allowed categories (case-sensitive), throw an ArgumentException with the message "University category {value} is not allowed in the application!"
		
	Capacity – int – the maximum possible number of students admitted to the university.
		If the value is less than zero throw ArgumentException with the message: "University capacity cannot be a negative value!"
		
	RequiredSubjects – IReadOnlyCollection<int> - A collection of integer values, representing the subject ids of all the subjects on which the student has to have the exams covered.

### Constructor

A University should take the following values upon initialization:

	int universityId, string universityName, string category, int capacity, 
	ICollection<int> requiredSubjects

### Data

	Models – IReadOnlyCollection<ISubject>

## Behavior

###void AddModel(ISubject subject)

	Adds a Subject in the collection.

### ISubject FindById(int id)

	Returns a Subject with the given id, if it exists in the repository, otherwise returns null.
	
### ISubject FindByName(string name)

	Returns a Subject with the given name, if it exists in the repository, otherwise returns null.

## StudentRepository

The repository holds information about the students.

### Data

	Models – IReadOnlyCollection<IStudent>

### Behavior

### void AddModel(IStudent student)

	Adds a Student in the collection.
	
### IStudent FindById(int id)

	Returns a Student with the given id, if it exists in the repository, otherwise returns null.
	
### IStudent FindByName(string name)

	Returns a Student with the given name (Split the given string by single space and check both the first and the last name of the student), if it exists in the repository, otherwise returns null.

