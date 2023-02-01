You need to implement a filtering module to a party reservation software. First, the Party Reservation Filter Module (PRFM for short) has been passed a list with invitations. Next, the PRFM receives a sequence of commands that specify whether you need to add or remove a given filter.

Each PRFM command is in the given format:

  "{command;filter type;filter parameter}"

You can receive the following PRFM commands: 

	"Add filter"
	"Remove filter"
	"Print" 

The possible PRFM filter types are: 

	"Starts with"
	"Ends with"
	"Length"
	"Contains"
  
All PRFM filter parameters will be a string (or an integer only for the "Length" filter). Each command will be valid e.g. you won't be asked to remove a non-existent filter. The input will end with a "Print" command, after which you should print all the party-goers that are left after the filtration. See the examples below:

## Examples:

![image](https://user-images.githubusercontent.com/45227327/216150397-102bee14-56c6-4d99-a049-fcee69323309.png)
