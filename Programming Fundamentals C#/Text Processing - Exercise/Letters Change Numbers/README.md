Nakov likes Math. But he also likes the English alphabet. He invented a game with numbers and letters from the English alphabet. The game was simple. You get a string consisting of a number between two letters. Depending on whether the letter was in front of the number or after it, you would perform different mathematical operations on the number to achieve the result.

First, you start with the letter before the number. 

	If it's uppercase you divide the number by the letter's position in the alphabet. 
	If it's lowercase you multiply the number with the letter's position in the alphabet. 

Then you move to the letter after the number. 

	If it's uppercase you subtract its position from the resulted number.
	If it's lowercase you add its position to the resulted number.

But the game became too easy for Nakov. He decided to complicate it a bit by doing the same but with multiple strings keeping track of only the total sum of all results. Once he started to solve this with more strings and bigger numbers, it became quite hard to do it only in his mind. So he kindly asks you to write a program that calculates the sum of all numbers after the operations on each number have been done.
