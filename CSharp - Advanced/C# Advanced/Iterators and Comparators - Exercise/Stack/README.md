Create your custom stack. You are aware of Stack's structure. There is a collection to store the elements and two functions (not from the functional programming) - to push an element and to pop it.

Keep in mind that the first element, which is popped is the last in the collection. The Push method adds an element at the top of the collection and the Pop method returns the top element and removes it. Push and Pop will be the only commands and they will come in the following format:

    "Push {element1}, {element2}, … {elementN}
     Pop
      … "
      
Write your custom implementation of Stack<T> and implement IEnumerable<T> interface. Your implementation of the GetEnumerator() method should follow the rules of the Abstract Data Type – Stack (return the elements in reverse order of adding them to the stack).
