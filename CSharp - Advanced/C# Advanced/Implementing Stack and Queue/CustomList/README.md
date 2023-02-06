### Details about the Structure

First of all, we must make it clear how our structure should work under the provided public functionality.

	It should hold a sequence of items in an array. 
	The structure should have a capacity that grows twice when it is filled, always starting at 2. 

The CustomList class should have the properties listed below:

	int[] items  – An array that will hold all of our elements.
	int Count – This property will return the count of items in the collection.
	indexer – The indexer will provide us with functionality to access the elements using integer indexes.

The structure will have internal methods to make the managing of the internal collection easier.

	Resize – this method will be used to increase the internal collection's length twice.
	Shrink – this method will help us to decrease the internal collection's length twice.
	Shift – this method will help us to rearrange the internal collection's elements after removing one.

### Implementation

Create a new public class CustomList and add a private constant field named InitialCapacity and set the value to 2. This field is used to declare the initial capacity of the internal array. It's always a good practice to use constants instead of magic numbers in your classes.
This approach makes the code better for managing and reading.
