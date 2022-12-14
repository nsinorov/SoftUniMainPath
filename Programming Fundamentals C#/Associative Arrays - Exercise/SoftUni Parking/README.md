SoftUni just got a new parking lot. It's so fancy, it even has online parking validation. Except the online service doesn't work. It can only receive users' data, but it doesn't know what to do with it. Good thing you're on the dev team and know how to fix it, right?

Write a program, which validates a parking place for an online service. Users can register to park and unregister to leave.

The program receives 2 commands:

	"register {username} {licensePlateNumber}":
    -	The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
    "ERROR: already registered with plate number {licensePlateNumber}"
    -	If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
    "{username} registered {licensePlateNumber} successfully"

	"unregister {username}":
    -If the user is not present in the database, the system should print:
     "ERROR: user {username} not found"
    -If the aforementioned check passes successfully, the system should print:
    "{username} unregistered successfully"

Input:

	First line: n - number of commands – integer.
	Next n lines: commands in one of the two possible formats:
     o	Register: "register {username} {licensePlateNumber}"
     o	Unregister: "unregister {username}"
     
The input will always be valid and you do not need to check it explicitly.

Examples:

![Capture](https://user-images.githubusercontent.com/45227327/201797654-7e1877b8-16ec-402d-82f0-94894082d4db.PNG)
