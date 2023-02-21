You will be given an integer n for the size of the battlefield (square shape). On the next n lines, you will receive the rows of the battlefield. The submarine will start at a random position, marked with the letter 'S'. The submarine surveys the surrounding area through its periscope, so it has to climb up to periscope depth, where it might run across naval mines. 

When the submarine receives direction, it goes deep and moves one position towards the given direction. On each turn, you will be guiding the submarine and giving it the direction, in which it should move. The commands will be "up", "down", "left" and "right".

When a new position is reached,  the submarine climbs up to periscope depth to search for a cruiser:


	If a position with '-' (dash) is reached, it means that the field is empty and the submarine awaits its next direction.
	If it runs across a naval mine ('*'), the submarine takes serious damage. When a mine is blown, the position of the mine will be marked with '-' (dash). U-9 can withstand two hits from naval mines.  The third time the submarine is hit by a mine, it disappears and the mission is failed. The battle is over and the following message should be printed on the Console: "Mission failed, U-9 disappeared! Last known coordinates [{row}, {col}]!"
  
	If a battle cruiser is reached ('C'), the submarine destroys it and the position of the destroyed cruiser will be marked with '-' (dash).
  
	If this is the last (third) battle cruiser on the battlefield, the battle is over and the following message should be printed on the Console: "Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!"

 The program will end when the battle is over (All battle cruisers are destroyed or the submarine hits mines three times).
 
### Input:

	On the first line, you are given the integer n – the size of the matrix (wall).
	The next n lines hold the values for every row.
	On each of the next lines, you will get a direction command.

### Output:

	If all battle cruisers are destroyed, print: "Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!"
	If U-9 is hit by a mine three times, print: "Mission failed, U-9 disappeared! Last known coordinates [{row}, {col}]!".
	At the end, print the final state of the matrix (battlefield) with the last known U-9’s position on it.

### Examples:

![image](https://user-images.githubusercontent.com/45227327/220458740-b76a0fe6-ae13-4177-a1a0-b8e7b7e4791f.png)
