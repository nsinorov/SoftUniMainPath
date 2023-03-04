Create 3 different string collections - AddCollection, AddRemoveCollection and MyList.

 The AddCollection should have:
 
	Only a single method Add which adds an item to the end of the collection.

 The AddRemoveCollection should have:
 
	An Add method - which adds an item to the start of the collection.
	A Remove method, which removes the last item in the collection.

 The MyList collection should have:
 
	An Add method, which adds an item to the start of the collection.
	A Remove method, which removes the first element in the collection.
	A Used property, which displays the number of elements currently in the collection. 

Create interfaces, which define the functionality of the collection, think about how to model the relations between interfaces to reuse code. Add an extra bit of functionality to the methods in the custom collections, Add() methods should return the index in which the item was added, Remove methods should return the item that was removed. 

Your task is to create a single copy of your collections, after which on the first input line you will receive a random number of strings in a single line separated by spaces - the elements you must add to each of your collections.
For each of your collections write a single line in the output that holds the results of all Add operations separated by spaces (check the examples to better understand the format). On the second input line, you will receive a single number - the amount of Remove operations you have to call on each collection.
In the same manner, as with the Add operations for each collection (except the AddCollection), print a line with the results of each Remove operation separated by spaces.
