Create a generic class ListyIterator. The collection, which it will iterate through, should be received by the constructor. You should store the elements in a List. The class should have three main functions:

	Move - should move an internal index position to the next index in the list. The method should return true, if it had successfully moved the index and false, if there is no next index.

	HasNext - should return true, if there is a next index and false, if the index is already at the last element of the list.

	Print - should print the element at the current internal index. Calling Print on a collection without elements should throw an appropriate exception with the message "Invalid Operation!". 

