You are provided with a project named "FightingArena" containing two classes - "Warrior" and "Arena". 

Your task here is simple - you need to write tests on the project covering the whole functionality. But before start writing tests, you need to get to know the project's structure and business logic.

Each Arena has a collection of Warriors enrolled for the fights. In the Arena, Warriors should be able to Enroll in the fights and fight each other. Each Warrior has a unique name, damage, and HP. Warriors can attack other Warriors. Of course, there is validations:

	Name cannot be null, empty, or whitespace
	Damage cannot be zero or negative
	HP cannot be negative
	Warrior cannot attack if his HP is below 30
	Warrior cannot attack Warriors whose HP are below 30
	Warrior cannot attack stronger enemies

On the Arena there should be performed some validations too:

	Already enrolled Warriors should not be able to enroll again
	There cannot be a figh if one of the Warriors is not enrolled for the fights
