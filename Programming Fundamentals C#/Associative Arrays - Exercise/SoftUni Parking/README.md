SoftUni just got a new parking lot. It's so fancy, it even has online parking validation. Except the online service doesn't work. It can only receive users' data, but it doesn't know what to do with it. Good thing you're on the dev team and know how to fix it, right?

Write a program, which validates a parking place for an online service. Users can register to park and unregister to leave.

The program receives 2 commands:

	"register {username} {licensePlateNumber}":
    -	The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
    "ERROR: already registered with plate number {licensePlateNumber}"
    -	If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
    "{username} registered {licensePlateNumber} successfully"

