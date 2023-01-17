You are given an empty text. Your task is to implement 4 commands related to manipulating the text:

	1 someString - appends someString to the end of the text.
	2 count - erases the last count elements from the text.
	3 index - returns the element at position index from the text.
	4 - undoes the last not undone command of type 1 or 2 and returns the text to the state before that operation.

## Input: 

	The first line contains n – the number of operations.
	Each of the following n lines contains the name of the operation, followed by the command argument, if any, separated by space in the following format "CommandName Argument".

## Output:

	For each operation of type 3 print a single line with the returned character of that operation.

## Examples:

![image](https://user-images.githubusercontent.com/45227327/213013975-70282db9-485b-4ec6-b2bd-4d421eef993b.png)
![image](https://user-images.githubusercontent.com/45227327/213014088-183e9c54-5abb-4fbf-9c4c-aa9acc32cdb7.png)
