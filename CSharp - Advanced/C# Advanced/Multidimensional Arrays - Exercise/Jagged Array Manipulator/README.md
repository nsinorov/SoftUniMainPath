Create a program that populates, analyzes and manipulates the elements of a matrix with an unequal length of its rows.

First, you will receive an integer N equal to the number of rows in your matrix.

On the next N lines, you will receive sequences of integers, separated by a single space. Each sequence is a row in the matrix.

After populating the matrix, start analyzing it. If a row and the one below it have equal length, multiply each element in both of them by 2, otherwise - divide by 2.

Then, you will receive commands. There are three possible commands:

	"Add {row} {column} {value}" - add {value} to the element at the given indexes, if they are valid.
	"Subtract {row} {column} {value}" - subtract {value} from the element at the given indexes, if they are valid.
	"End" - print the final state of the matrix (all elements separated by a single space) and stop the program.

## Input: 

	On the first line, you will receive the number of rows of the matrix - integer N.
	On the next N lines, you will receive each row – sequence of integers, separated by a single space
	{value} will always be an integer number.
	Then you will be receiving commands until reading "End".

## Output:

	The output should be printed on the console and it should consist of N lines.
	Each line should contain a string representing the respective row of the final matrix, elements separated by a single space.

## Examples:

![image](https://user-images.githubusercontent.com/45227327/213917877-e29266e6-6ad7-4269-bf9e-ae5aef5d5092.png)
![image](https://user-images.githubusercontent.com/45227327/213917909-6cb4fe8d-8a9f-4fac-af76-909b04110a0a.png)
