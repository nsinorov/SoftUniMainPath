The doubly linked list is a structure that resembles a list but has different functionalities. Each element in it "knows" about the previous one, if it is such, and the next one, again, if there is such. This is possible because the doubly linked list has nodes and each node has two reference properties pointing to other nodes and a value property, which contains some kind of data.

By definition, the doubly linked list has a head (list start) and a tail (list end). The typical operations over a doubly linked list add/remove an element at both of the endings and traverse.

If you are interested, you can find more detailed information here: https://en.wikipedia.org/wiki/Doubly_linked_list.

This figure shows how the structure looks:

![image](https://user-images.githubusercontent.com/45227327/216958397-4e404b68-65e5-4155-b47c-869c3c166031.png)

### Implementation:

The first step when implementing a linked / doubly linked list is to understand that we need two classes:

	ListNode – a class to hold a single list node (its value + next node + previous node)
	DoublyLinkedList – a class that holds the entire list (it's head + tail + operations)

Now, let's create the ListNode class. It should hold a Value and a reference to its previous and next node. We can do that inside the DoublyLinkedList class because we will use it only internally inside it. 

### Implement AddFirst(int) Method

Adding an element at the beginning of the list (before its head) has two scenarios (considered in the above code):

	Empty list  add the new element as head and tail at the same time.
	Non-empty list  add the new element as a new head and redirect the old head as the second element, just after the new head.

![image](https://user-images.githubusercontent.com/45227327/216958791-25a30c59-c0b1-46a2-bba7-3c8b6989e1e1.png)

 
The above graphic visualizes the process of inserting a new node at the start (head) of the list. The red arrows denote the removed pointers from the old head. The green arrows denote the new pointers to the new head.
