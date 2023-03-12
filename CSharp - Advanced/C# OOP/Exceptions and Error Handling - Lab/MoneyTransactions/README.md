You will receive on the first line a collection of bank accounts, consisting of an account number (integer) and its balance (double), in the following format:

    "{account number}-{account balance},{account number}-{account balance},…"

 After that, until the "End" command, you will receive commands, which should manipulate the given accounts balance:

	"Deposit {account number} {sum}" – Add the given sum to the given account`s balance. 
	"Withdraw {account number} {sum}" – Subtract the given sum from the account`s balance.

Print the following messages from the exceptions which can be produced from your program:

	If you receive an invalid command:

"Invalid command!"

	If you receive an account, which does not exist:

"Invalid account!"

	If you receive the "Withdraw" command with the sum, which is bigger than the balance:

"Insufficient balance!"

In all cases, after each received command, print the message:

	"Enter another command"

After each successful operation print, the new balance is formatted to the second integer after the decimal point:

	"Account {account number} has new balance: {balance}"

### Examples:

![image](https://user-images.githubusercontent.com/45227327/224575061-b9858639-e5a8-41aa-b945-ac478f1f3500.png)
![image](https://user-images.githubusercontent.com/45227327/224575077-8c08be62-375b-49cf-8619-a1b63b31fde4.png)

Constraints

	The types of the elements of the given command line will be valid
	You will always receive 3 elements in each command line
