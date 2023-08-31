You are the captain of a space exploration team in the year 2150. Your team consists of astronauts, and you need to manage their resources and actions during your mission. Each astronaut has a name, oxygen level, and energy reserves.

On the first line of the standard input, you will receive an integer n – the number of astronauts in your team. On the next n lines, the astronauts' details will follow with their names, oxygen levels, and energy reserves separated by a single space in the following format:

    "{astronaut name} {oxygen level} {energy reserves}" 

Oxygen level represents the remaining oxygen in the astronaut's suit, ranging from 0 to 100.

Energy reserves represent the remaining energy in the astronaut's suit, ranging from 0 to 200.

After you have formed your team, you will receive different commands, each on a new line, separated by " - ", until the "End" command is given. There are three actions that the astronauts can perform: 

    "Explore – {astronaut name} – {energy needed}"

  If the astronaut has enough energy reserves, they can perform an exploration task, thus reducing their energy reserves. Print this message:

    	"{astronaut name} has successfully explored a new area and now has {energy reserves left} energy!"

  If the astronaut does not have enough energy to perform the task, print:

    	"{astronaut name} does not have enough energy to explore!"

    "Refuel – {astronaut name} – {amount}"

	The astronaut refuels their energy reserves. If it brings the energy reserves of the astronaut above the maximum value (200), the energy reserves are increased to 200 (the energy reserves can't go over the maximum value).

   Print the following message:

	 "{astronaut name} refueled their energy by {amount recovered}!"
  
	"Breathe – {astronaut name} – {amount}"

  If The astronaut replenishes their oxygen level. If a command is given that would bring the oxygen level of the astronaut above the maximum value (100), the oxygen level is increased to 100 (the oxygen level can't go over the maximum value).

 Print the following message:
 
	"{astronaut name} took a breath and recovered {amount recovered} oxygen!"

### Input:

	On the first line of the standard input, you will receive an integer n

	On the following n lines, the astronauts themselves will follow with their oxygen level and energy reserves, separated by a space in the following format

	You will be receiving different commands, each on a new line, separated by " - ", until the "End" command is given

### Output:

	Every command should print its own template sentence, after that print all astronauts, in the following format:
 
		"Astronaut: {astronaut name}, Oxygen: {oxygen level}, Energy: {energy reserves}"

### Constraints:

	The names of the astronauts will always be unique.
	All given commands will be valid.
