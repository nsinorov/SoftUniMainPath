Use your solution of the previous task for the starting point and add more functionality. Add a new vehicle – Bus. Add to every vehicle a new property – tank capacity. A vehicle cannot start with or refuel above its tank capacity.

If you try to put more fuel in the tank than the available space, print on the console "Cannot fit {fuel amount} fuel in the tank" and do not add any fuel in the vehicle’s tank. If you try to create a vehicle with more fuel than its tank capacity, create it but start with an empty tank.

Add a new command for the bus. You can drive the bus with or without people. With people, the air-conditioner is turned on and its fuel consumption per kilometer is increased by 1.4 liters. If there are no people on the bus, the air-conditioner is turned off and does not increase the fuel consumption.

Finally, add validation for the amount of fuel given to the Refuel command – if it is 0 or negative, print "Fuel must be a positive number".

### Input:

	On the first three lines you will receive information about the vehicles in the format:
  	"Vehicle {initial fuel quantity} {liters per km} {tank capacity}"
	On the fourth line - the number of commands N that will be given on the next N lines
	On the next N lines - commands in format:
		"Drive Car {distance}"
		"Drive Truck {distance}"
		"Drive Bus {distance}"
		"DriveEmpty Bus {distance}"
		"Refuel Car {liters}"
		"Refuel Truck {liters}"
		"Refuel Bus {liters}"

### Output:

	After each Drive command, if there was enough fuel, print on the console a message in the format:
		"Car/Truck travelled {distance} km"
	If there was not enough fuel, print:
		"Car/Truck needs refueling"
	If you try to refuel with an amount ≤ 0 print:
		"Fuel must be a positive number"
	If the given fuel cannot fit in the tank, print:
		"Cannot fit {fuel amount} fuel in the tank"
	After the "End" command, print the remaining fuel for all vehicles, rounded to 2 digits after the floating point in the format:
		"Car: {liters}"
		"Truck: {liters}"
		"Bus: {liters}"

### Example:

![image](https://user-images.githubusercontent.com/45227327/223854125-4946ff09-cb3d-4d53-b41c-bf8129bf0510.png)
![image](https://user-images.githubusercontent.com/45227327/223854251-aeb81eb9-114b-4367-84fd-3f72cd791306.png)
