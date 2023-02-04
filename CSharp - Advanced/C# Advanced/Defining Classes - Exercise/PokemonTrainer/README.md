Define a class Trainer and a class Pokemon. 

Trainers have:

	Name
	Number of badges
	A collection of pokemon

Pokemon have:

	Name
	Element
	Health

All values are mandatory. Every Trainer starts with 0 badges.

You will be receiving lines until you receive the command "Tournament". Each line will carry information about a pokemon and the trainer who caught it in the format:

	"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"

TrainerName is the name of the Trainer who caught the pokemon. Trainers' names are unique.

After receiving the command "Tournament", you will start receiving commands until the "End" command is received. They can contain one of the following:

	"Fire"
	"Water"
	"Electricity"
