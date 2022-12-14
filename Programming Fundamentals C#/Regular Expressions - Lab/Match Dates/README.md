Write a program, which matches a date in the format "dd{separator}MMM{separator}yyyy". Use named capturing groups in your regular expression.

Every valid date has the following characteristics:

	Always starts with two digits, followed by a separator.
	After that, it has one uppercase and two lowercase letters (e.g. Jan, Mar).
	After that, it has a separator and exactly 4 digits (for the year).
	The separator could be either of three things: a period ('. '), a hyphen ('-') or a forward-slash ('/').
	The separator needs to be the same for the whole date (e.g. 13.03.2016 is valid, 13.03/2016 is NOT). Use a group backreference to check for this.

Now it's time to find all the valid dates in the input and print each date in the following format: "Day: {day}, Month: {month}, Year: {year}", each on a new line.

## Examples: 

![Capture](https://user-images.githubusercontent.com/45227327/204632309-833592a8-bcb3-46d0-ba43-d4a155cc30d1.PNG)
