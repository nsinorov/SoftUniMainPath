### Details about the Structure

The implementation of a custom stack is much easier, mostly because you can only execute actions over the last index of the collection, plus you can iterate through the collection. You should be able to create it entirely on your own.

The first thing you can do is have a clear vision of how you want your structure to work under the provided public functionality. 

For example:

	It should hold a sequence of items in an array. 
	The structure should have a capacity that grows twice when it is filled, always starting at 4. 
  
The CustomStack class should have the properties listed below:

	int[] items – An array, which will hold all of our elements.
	int Count – This property will return the count of items in the collection.
	const int InitialCapacity – this constant's value will be the initial capacity of the internal array.
