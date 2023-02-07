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

### Implementation

Create a new public class CustomStack and add a private constant field named InitialCapacity and set the value to 4. This field is used to declare the initial capacity of the internal array.

We already know that it's not a good practice to have magic numbers in your code. Afterward, we are going to declare our internal array and a field for the count of elements in our collection.

Of course, you have to initialize the collection. Also, set the count variable to 0. As we already know, this can be done inside the constructor of the class:
