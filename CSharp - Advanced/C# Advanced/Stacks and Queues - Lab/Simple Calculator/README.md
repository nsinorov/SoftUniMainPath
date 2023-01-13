Create a simple calculator that can evaluate simple expressions with only addition and subtraction. There will not be any parentheses. Numbers and operations are space-separated.

Solve the problem using a Stack.

## Examples:

![image](https://user-images.githubusercontent.com/45227327/212358791-0b080243-2422-4b8e-b10d-476f82e78ba9.png)

![Capture](https://user-images.githubusercontent.com/45227327/212358810-7a832943-daed-412c-b785-5592e41d435a.PNG)

## Hints:

	Split the input expression by space to extract its tokens (numbers and operations).
	Reverse the input tokens, then push them in a Stack<string>.
	Example:
	Input expression: 2 + 5 + 10 - 2 - 1
	Stack: 1 - 2 - 10 + 5 + 2
	Pop the last number (in the above example 2). It is the current result.
	Pop an operation and number (e. g. + 5). Execute the operation. In our example: result = 2 + 5 = 7.
	Repeat the previous step until the stack gets empty.

