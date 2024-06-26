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

Next, you have to add a public property Count that holds the value of the count field. This way, you will be able to get the count of items in the collection from other classes.

Now you can proceed to the implementation of the methods, which your CustomStack is going to have.
All of the functionality described in the description is very easy to implement, so we strongly recommend for you try to do it on your own. If you have any difficulties, you can help yourself with the code snippets below.

### Implement void Push(int Element) Method

This method adds an element to the end of the collection, just like the C# Stack Push() method does. This is a very easy task. 

### Implement int Pop() Method

The Pop() method returns the last element from the collection and removes it. The implementation is easier than the implementation of the RemoveAt(int index) and Remove() methods of the CustomList. Try to implement it on your own. 

### Implement int Peek() Method

The Peek() method has the same functionality as the C# Stack – it returns the last element from the collection, but it doesn't remove it. The only thing we need to consider is that you can't get an element from an empty collection, so you must make sure you have the proper validation. For sure, you will be able to implement it on your own.

### Implement void ForEach(Action<object> Action) Method

### This method goes through every element from the collection and executes the given action.

### You can add any kind of functionalities to your CustomStack and afterward you can test how it works in your Main() method in your StartUp class.
