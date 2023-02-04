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

For every command, you must check if a trainer has at least 1 pokemon with the given element. If he does, he receives 1 badge. Otherwise, all of his pokemon lose 10 health. 

If a pokemon falls to 0 or less health, he dies and must be deleted from the trainer's collection. In the end, you should print all of the trainers, sorted by the number of badges they have in descending order (if two trainers have the same amount of badges, they should be sorted by order of appearance in the input) in the format: 

	"{trainerName} {badges} {numberOfPokemon}"
