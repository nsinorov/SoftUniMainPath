You are provided with a simple class – Database, which stores integers. The constructor receives an array of numbers, which is added into a private field. 

The database has the functionality to add, remove and fetch all stored items. Your task is to test the class. In other words, write tests, so you are sure its methods are working as intended.

### Constraints:

    Storing array's capacity must be exactly 16 integers
  		If the size of the array is not 16 integers long, InvalidOperationException is thrown
		
    The "Add()" operation, should add an element at the next free cell (just like a stack)
		If there are 16 elements in the Database and try to add 17th, InvalidOperationException is thrown

	The "Remove()" operation, should support only removing an element at the last index (just like a stack)
		If you try to remove an element from an empty Database, InvalidOperationException is thrown
