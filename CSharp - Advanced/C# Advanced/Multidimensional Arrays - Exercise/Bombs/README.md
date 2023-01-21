You will be given a square matrix of integers, each integer separated by a single space and each row on a new line. Then on the last line of input, you will receive indexes - coordinates to several cells separated by a single space, in the following format: row1,column1 row2,column2 row3,column3 … 

On those cells there are bombs. You have to proceed with every bomb, one by one in the order they were given. When a bomb explodes deals damage equal to its integer value, to all the cells around it (in every direction and all diagonals). One bomb can't explode more than once and after it does, its value becomes 0. When a cell's value reaches 0 or below, it dies. Dead cells can't explode.

You must print the count of all alive cells and their sum. Afterward, print the matrix with all of its cells (including the dead ones). 

## Input:

	On the first line, you are given the integer N – the size of the square matrix.
	The next N lines hold the values for every row – N numbers separated by a space.
	On the last line, you will receive the coordinates of the cells with the bombs in the format described above.

## Output:

	On the first line, you need to print the count of all alive cells in the format: 
		"Alive cells: {aliveCells}"
	On the second line, you need to print the sum of all alive cells in the format: 
		"Sum: {sumOfCells}"
	At the end print the matrix. The cells must be separated by a single space.
