### Details about the Structure

When implementing a custom queue keep in mind that you can add elements at the end and remove elements from the beginning of the queue, plus you can iterate through the collection.

You should be able to create it entirely on your own. The first thing you can do is have a clear vision of how you want your structure to work under the provided public functionality. For example:

	It should hold a sequence of items in an array. 
	The structure should have a capacity that grows twice when it is filled, always starting at 4. 
