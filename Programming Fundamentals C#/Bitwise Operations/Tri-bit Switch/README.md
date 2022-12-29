Write a program that inverts the 3 bits from position p to the left with their XOR opposites (e.g., 111 -> 000, 101 -> 010) in a 32-bit number. Print the resulting integer on the console.

## Examples: 

![image](https://user-images.githubusercontent.com/45227327/209887283-210c4c08-b14a-4ae4-bc9f-c3df9443b313.png)

Hints

1.	Shift the number 7 (the number 7 has the bits 111, which we use to get 3 consecutive values), p times to the left (where p is the position) by using the << operator. In that way, the 3 bits we want to invert will be at position p. Save the resulting value in the mask.
2.	Use the ^ mask operator expression to invert the values of the three bits starting from position p. By using the following formulae (n ^ mask), you copy all the bits of the number, and you invert the bits at position p, p+1, and p+2.
3.	Save the result in result.
