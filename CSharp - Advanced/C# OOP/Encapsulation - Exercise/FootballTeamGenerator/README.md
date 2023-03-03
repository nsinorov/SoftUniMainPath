A football Team has a variable number of players, a name, and a rating. A Player has a name and stats, which are the basis for his skill level. The stats a player has are endurance, sprint, dribble, passing, and shooting. Each stat can be an integer in the range [0..100]. The overall skill level of a player is calculated as the average of his stats. Only the name of a player and his stats should be visible to the entire outside world. Everything else should be hidden.

A Team should expose a name, a rating (calculated by the average skill level of all players in the team and rounded to the integer part only), and methods for adding and removing players.

Your task is to model the Team and the Player classes following the proper principles of Encapsulation. Expose only the properties that need to be visible and validate data appropriately.

### Input

Your application will receive commands until the "END" command is given. The command can be one of the following:

	"Team;{TeamName}" - add a new Team;
	"Add;{TeamName};{PlayerName};{Endurance};{Sprint};{Dribble};{Passing};{Shooting}" - add a new Player to the Team;
	"Remove;{TeamName};{PlayerName}" - remove the Player from the Team;
	"Rating;{TeamName}" - print the Team rating, rounded to an integer.

### Data Validation

	A name cannot be null, empty, or white space. If not, print "A name should not be empty."
	Stats should be in the range 0..100. If not, print "[Stat name] should be between 0 and 100."
	If you receive a command to remove a missing Player, print "Player [Player name] is not in [Team name] team."
	If you receive a command to add a Player to a missing Team, print "Team [team name] does not exist."
	If you receive a command to show stats for a missing Team, print "Team [team name] does not exist."

