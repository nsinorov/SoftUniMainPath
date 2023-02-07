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

Now let's create the initial collection, which is a private array of type int. To initialize the array, we will use the constructor of the class.
Keep in mind that if the internal array has a length of 4, this doesn't mean that our collection holds 4 elements. So we need a property, which will keep the information of the actual count of the elements in the structure.

This property should be updated every single time when we make changes related to the count of the elements like adding or removing.
It would be awesome if we can access the items in the collection without exposing the internal array. So, let's implement this functionality. 

When somebody tries to access our collection using an index, the get accessor is invoked and the indexer will return the value on the given index. When someone is trying to set a value to a given index the set accessor is invoked.

In both accessors, we must check if the index is less than the Count and greater or equal to zero because our structure actual items count might be different from the internal array length.

### Implement Void Add(int Element) Method

It is time to create the method, which adds a new element to the end of our collection, just like in the C# lists. It looks like an easy task, but keep in mind that if our internal array is filled, we have to increase it by twice the length it currently has and add the new element.

To make our job easier let's create a Resize() method first. The method should be used only within the class so it must be private. 

### Implement int RemoveAt(int Index) Method

The RemoveAt() method has the functionality to remove an item on the given index and return the item. Let's think about how to solve this problem by dividing it into smaller tasks.

	First, we must check if the index is valid and if not, we should throw ArgumentOutOfRangeException.
	Get the item on the given index and assign it to a variable, which will be returned at the end.
	Set the value on the given index to the default value of int.
	Now we have an empty element and we need to shift the elements.
	Reduce the count and check if the count is 4 times smaller than the internal array length. If it is we have to think about a way to shrink the array.
	In the end, return the variable to which we assigned the value of the requested index. 

So you already know that we need to implement the other 2 internal methods **Shift()** and **Shrink()**.

### Void Shift(int Index)

The shift method uses a loop, which moves all the elements to the left starting from a given index.

### Void Shrink()

The Shrink() method is the same as the Resize() method with the small difference that it will reduce the length twice, instead of increasing it. 

### Implement void Insert(int Index, Int Item) Method

You are already familiar with this method, so let us go straight to the implementation. First of all, we will split the logic into smaller tasks:

	We have an index parameter, so we must validate the index.
	We must check if the array should be resized.
	We have to rearrange the items to free the space for the required index.
	Finally, insert the given item on the index and increase the count.

You probably have already noticed, that since we have a method to rearrange the items to the left, used to fill up the space when we remove an item, we must have a method to rearrange items to the right, so let's create it.

Starting from the end of the actual elements, this method will copy every single item on the next index. The loop will end on the requested index.

### Implement bool Contains(int Element) Method

This method should check if the given element is in the collection. Return true, if it is and false, if it's not. It's a simple task, so you should do it all on your own.  

***Hint:*** When you are iterating through the items, use the "Count" property as an end condition, instead of the internal array length.

### Implement void Swap(int FirstIndex, Int SecondIndex) Method

Just like the method above, we consider this an easy task for you. Of course, you have a hint. When we work with indexes, we must always check if they are less than the count, because you may end up in the situation, where the collection has 3 actual elements, while the internal array has a length of 4.

If you have good ideas to implement new functionalities, like Find(), Reverse() or overriding ToString methods, feel free to do it.
