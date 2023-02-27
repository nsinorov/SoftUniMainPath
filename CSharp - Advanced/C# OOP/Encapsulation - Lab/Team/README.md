NOTE: You need a public StartUp class with the namespace PersonsInfo. The skeleton from the previous task could be used.

Create a Team class. Add to this team all of the people you have received. Those who are younger than 40 go to the first team, others go to the reserve team. At the end print the sizes of the first and the reserved team.

The class should have private fields for:

	name: string
	firstTeam: List<Person>
	reserveTeam: List<Person>

The class should have constructors:

	Team(string name)
  
The class should also have public properties for:

	FirstTeam: List<Person> (read-only!)
	ReserveTeam: List<Person> (read-only!)
  
And a method for adding players:

	AddPlayer(Person person): void

### Examples:

![image](https://user-images.githubusercontent.com/45227327/221664739-213a3a9e-1535-4ed8-9ef3-09e198aed6fb.png)
![image](https://user-images.githubusercontent.com/45227327/221664846-68ee0258-1cd1-4711-8503-2e9a375e8073.png)
