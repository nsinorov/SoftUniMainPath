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

### Implement AddLast(int) Method

Next, implement the AddLast(int element) method for appending a new element as the list tail. It should be very similar to the AddFirst(int element) method. The logic inside it is the same, but we append the new element at the tail instead of at the head. 

### Implement RemoveFirst() Method

Next, let's implement the method RemoveFirst()  int. It should remove the first element from the list and move its head to point to the second element. The removed element should be returned as a result of the method. In case of an empty list, the method should throw an exception. We have to consider the following three cases:

	Empty list  throw an exception.
	Single element in the list  make the list empty (head == tail == null).
	Multiple elements in the list  remove the first element and redirect the head to point to the second element (head = head.NextNode).

### Implement RemoveLast() Method

Next, let's implement the method RemoveLast()  int. It should remove the last element from the list and move its tail to point to the element before the last. It is very similar to the method RemoveFirst(). 

### Implement ForEach(Action) Method

We have a doubly-linked list. We can add elements to it. But we cannot see what's inside, because the list still does not have a method to traverse its elements (pass through each of them, one by one).

Now let's define the ForEach(Action<int>) method. In programming, such a method is known as a "visitor" pattern. It takes as an argument a function (action) to be invoked for each of the elements of the list.

The algorithm behind this method is simple: start from the head and pass to the next element until the last element is reached (its next element is null). A sample implementation is given below:
	
	For example, if you want to print all of the elements you can use the following code:
	
![image](https://user-images.githubusercontent.com/45227327/216959261-a9cf4d68-b93f-496c-8445-957faf56c2a9.png)

 
Where list is DoublyLinkedList type object.

