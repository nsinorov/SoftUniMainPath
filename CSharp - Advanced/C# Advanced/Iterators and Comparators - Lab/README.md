### First problem:  1.	Library

Note: Put your classes in the namespace IteratorsAndComparators. Also your Visual Studio project should be named “IteratorsAndComparators”, as well as your assembly name (it is inherited from the Visual Studio project name).

Create a class Book, which should have the following public properties:

	string Title
	int Year
	List<string> Authors

Authors can be zero (anonymous), one or many. A Book should have only one constructor.

Create a class Library, which should store a collection of books and implement the IEnumerable<Book> interface. 
	
	List<Book> books
	
A Library could be initialized without books or with any number of books and should have only one constructor.

### Second problem
