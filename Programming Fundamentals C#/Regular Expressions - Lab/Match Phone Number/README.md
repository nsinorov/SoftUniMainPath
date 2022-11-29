Create a regular expression to match a valid phone number from Sofia. After you find all valid phones, print them on the console, separated by a comma and a space ", ".

A valid number has the following characteristics:

	It starts with "+359"
	Then, it is followed by the area code (always 2)
	After that, it's followed by the number itself:
	The number consists of 7 digits (separated into two groups of 3 and 4 digits respectively). 
	The different parts are separated by either a space or a hyphen ('-').
  
You can use the following RegEx properties to help with the matching: 
    
    Use quantifiers to match a specific number of digits
    Use a capturing group to make sure the delimiter is only one of the allowed characters (space or hyphen) and not a combination of both (e.g. +359 2-111 111 has mixed delimiters, it is invalid). Use a group backreference to achieve this.
  	Add a word boundary at the end of the match to avoid partial matches (the last example on the right-hand side).
  	Ensure that before the '+' sign there is either a space or the beginning of the string.

## Examples: 

![Capture](https://user-images.githubusercontent.com/45227327/204631955-d9ea3cf5-01b5-430c-8d0e-f9274d44b1f5.PNG)
