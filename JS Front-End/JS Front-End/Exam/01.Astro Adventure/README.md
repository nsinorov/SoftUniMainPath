You are the captain of a space exploration team in the year 2150. Your team consists of astronauts, and you need to manage their resources and actions during your mission. Each astronaut has a name, oxygen level, and energy reserves.

On the first line of the standard input, you will receive an integer n – the number of astronauts in your team. On the next n lines, the astronauts' details will follow with their names, oxygen levels, and energy reserves separated by a single space in the following format:

    "{astronaut name} {oxygen level} {energy reserves}" 

Oxygen level represents the remaining oxygen in the astronaut's suit, ranging from 0 to 100.

Energy reserves represent the remaining energy in the astronaut's suit, ranging from 0 to 200.

After you have formed your team, you will receive different commands, each on a new line, separated by " - ", until the "End" command is given. There are three actions that the astronauts can perform: 

    "Explore – {astronaut name} – {energy needed}"

•	If the astronaut has enough energy reserves, they can perform an exploration task, thus reducing their energy reserves. Print this message:

    o	"{astronaut name} has successfully explored a new area and now has {energy reserves left} energy!"
