Your task is to create a class hierarchy like the one described below. The BaseHero class should be abstract.

	BaseHero – string Name, int Power, string CastAbility()
  	Druid – power = 80
  	Paladin – power = 100
  	Rogue – power = 80
  	Warrior – power = 100

Each hero should override the CastAbility() method:

	Druid - "{Type} - {Name} healed for {Power}"
	Paladin - "{Type} - {Name} healed for {Power}"
	Rogue - "{Type} - {Name} hit for {Power} damage"
	Warrior - "{Type} - {Name} hit for {Power} damage"

Now use the classes you created to form a raid group and defeat a boss.

You will receive an integer N from the console. On the next lines, you will receive {heroName} and {heroType} until you create N number of heroes. If the hero type is invalid print: "Invalid hero!" and don’t add it to the raid group. After the raid group is formed you will receive an integer from the console which will be the boss’s power.

Then each of the heroes in the raid group should cast his ability once. You should sum the power of all of the heroes and if the total power is greater or equal to the boss’s power you have defeated him and you should print:

	"Victory!"

Else print:
	
	"Defeat..."
	
### Bonus*

Use the Factory Design pattern to instantiate the classes.

### Example:

![image](https://user-images.githubusercontent.com/45227327/224398299-2ad103f6-e185-4591-b2d1-78d3f4ce900d.png)
