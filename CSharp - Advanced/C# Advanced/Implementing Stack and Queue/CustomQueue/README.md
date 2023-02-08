### Details about the Structure

When implementing a custom queue keep in mind that you can add elements at the end and remove elements from the beginning of the queue, plus you can iterate through the collection.

You should be able to create it entirely on your own. The first thing you can do is have a clear vision of how you want your structure to work under the provided public functionality. For example:

	It should hold a sequence of items in an array. 
	The structure should have a capacity that grows twice when it is filled, always starting at 4. 

The CustomQueue class should have the properties listed below:

	void Enqueue(int element) – Adds the given element to the queue
	int Dequeue() – Removes the first element
	int Peek() – Returns the first element in the queue without removing it
	void Clear() – Delete all elements in the queue
	void ForEach(Action<int> action) – Goes through each of the elements in the queue

### Implementation

Create a new public class CustomQueue and add a private constant field named InitialCapacity and set the value to 4. This field is used to declare the initial capacity of the internal array.
We already know that it's not a good practice to have magic numbers in your code, so we should add also FirstElementIndex and set its value to 0, which represents the index of the first element. Afterward, we are going to declare our internal array and a field for the count of elements in our collection.

Of course, you must initialize the collection. Also, set the count variable to 0. As we already know, this can be done inside the constructor of the class.
