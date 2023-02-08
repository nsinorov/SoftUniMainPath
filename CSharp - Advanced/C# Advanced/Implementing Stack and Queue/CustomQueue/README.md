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

Next, you must add a public property Count that holds the value of the count field. This way, you will be able to get the count of items in the collection from other classes.

Now you can proceed to the implementation of the methods, which your CustomQueue is going to have. All of the functionality described in the description is very easy to implement, so we strongly recommend for you try to do it on your own. 

### Implement void Enqueue(int Element) Method

This method adds an element at the beginning of the collection, just like the C# Queue Enqueue() method does. This is a very easy task. 

You also need to implement a private method IncreaseSize, which will double the size of the inner array.

### Implement int Dequeue() Method

The Dequeue() method returns the first element from the collection and removes it. The implementation is easier than the implementation of the RemoveAt(int index) and Remove() methods of the CustomList. Try to implement it on your own. 

### Implement int Peek() Method

The Peek() method has the same functionality as the C# Qeueue – it returns the first element from the collection, but it doesn't remove it. The only thing we need to consider is that you can't get an element from an empty collection, so you must make sure you have the proper validation. For sure, you will be able to implement it on your own.

### Implement int Clear() Method

The Clear() method has the same functionality as the C# Qeueue – it removes all the elements from the collection. The only thing we need to consider is that you can't remove an element from an empty collection, so you must make sure you have the proper validation. For sure, you will be able to implement it on your own.

### Implement void ForEach(Action<object> Action) Method
	
***This method goes through every element from the collection and executes the given action. The implementation is very easy, but it requires some additional knowledge.***
	
You can add any kind of functionalities to your CustomQueue and afterward you can test how it works in your Main() method in your StartUp class.
