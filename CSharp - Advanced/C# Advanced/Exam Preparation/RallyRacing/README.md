On the first line, you will be given an integer N, which represents the size of a square matrix. On the second line you will receive the racing number of the tracked race car.

On the next N lines you will be given the rows of  the matrix (string sequences, separated by whitespace), which will be representing the race route. The tracked race car always starts with coordinates [0, 0].

Thеre will be a tunnel somewhere across the race route. If the race car runs into the tunnel , the car goes through it and exits at the other end. There will be always two positions marked with "T"(tunnel).

The finish line will be marked with "F". All other positions will be marked with ".".

Keep track of the kilometers passed. Every time the race car receives a direction and moves to the next position of the race route, it covers 10 kilometers. If the car goes through the tunnel, it covers NOT 10, but 30 kilometers.

On each line, after the matrix is given, you will be receiving the directions for the race car:

	left
	right
	up
	down

The race car starts moving across the race route:

	If you receive "End" command, before the race car manages to reach the finish line, the car is disqualified and the following output should be printed on the Console: "Racing car {racing number} DNF."
	
	If the race car comes across a position marked with ".". The car passes 10 kilometers for the current move and waits for the next direction.
	
	If the race car comes across a position marked with "T" this is the tunnel. The race car goes through it and moves to the other position marked with  "T" (the other end of the tunnel). The car passes 30 kilometers for the current move. The tunnel stays behind the car, so the race route is clear, and both the positions marked with "T", should be marked with ".".
	
	If the car reaches the finish line - "F" position, the race is over. The tracked race car manages to finish the stage and the following output should be printed on the Console: "Racing car {racing number} finished the stage!". Don’t forget that the car has covered another 10 km with the last move.

### Input:

	On the first line you will receive N - the size of the square matrix (race route)
	On the second line you will receive the racing number of the tracked car
	On the next N lines, you will receive the race route (elements will be separated by a space).
	On the following lines, you will receive directions (left, right, up, down).
	On the last line, you will receive the command "End".
