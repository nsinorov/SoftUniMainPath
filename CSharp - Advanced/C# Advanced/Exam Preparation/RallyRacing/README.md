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

