You already have a class - Database. We have modified it and added some more functionality to it.

It supports adding, removing, and finding People. In other words, it stores People. There are two types of finding methods - first: "FindById (long id)" and the second one: "FindByUsername (string username)".

As you may guess, each person has unique id and unique username. Your task is to test the provided project.

### Constraints:

The database should have methods:

	Add
	  If there are already users with this username, InvalidOperationException is thrown
	  If there are already users with this id, InvalidOperationException is thrown
