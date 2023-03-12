You will receive on the first line an array of integers. After that you will receive commands, which should manipulate the array:

	"Replace {index} {element}" – Replace the element at the given index with the given element. 
	"Print {startIndex} {endIndex}" – Print the elements from the start index to the end index inclusive.
	"Show {index}" – Print the element at the index.

You have the task to rewrite the messages from the exceptions which can be produced from your program:

	If you receive an index, which does not exist in the array print:

"The index does not exist!"

	If you receive a variable, which is of invalid type:

"The variable is not in the correct format!"

 When you catch 3 exceptions – stop the input and print the elements of the array separated with ", ".

### Examples:

![image](https://user-images.githubusercontent.com/45227327/224575159-a2f3a0ca-1be2-4cc0-87dc-79ef06cd0189.png)
![image](https://user-images.githubusercontent.com/45227327/224575204-b77239f5-87b6-4476-8789-ecb5226968d0.png)
