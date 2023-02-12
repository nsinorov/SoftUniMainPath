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

### Second problem  2.Library Iterator

Note: Put your classes in the namespace IteratorsAndComparators.
	
Extend your solution from the previous task. Inside the Library, create a nested class LibraryIterator, which should implement the IEnumerator<Book> interface. Try to implement the bodies of the inherited methods by yourself. You will need two more members:

	List<Book> books
	int currentIndex
	
Now you should be able to iterate through a Library in the Main method.
