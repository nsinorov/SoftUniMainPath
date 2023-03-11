Create a class Card to hold a card’s face and suit.

	Valid card faces are: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
	Valid card suits are: S (♠), H (♥), D (♦), C (♣)

Both face and suit are expected as an uppercase string. The class also needs to have a toString() method that prints the card’s face and suit as a string in the following format:

	"[{face}{suit}]" – example: [A♠] [5♣] [10♦]

Use the following UTF code literals to represent the suits:

	\u2660 – Spades (♠)
	\u2665 – Hearts (♥)
	\u2666 – Diamonds (♦)
	\u2663 – Clubs (♣)

Write a program that takes a deck of cards as a string array and prints them as a sequence of cards (space separated). Print an exception message "Invalid card!" when an invalid card definition is passed as input.
