# 1.	Overview

We are in the year 2100. Technology is so advanced that robots are all around us. They are autonomous and do whatever you tell them to do. They use fluidization instead of charging to provide the energy they need, so robots need to be fed.

You are working on a robot service and you need to create a RobotService project to monitor the actions of a robot. Each service has a robot that requires different care. Your job is to add, feed and take care of the robot, as well as upgrade it with various supplements.

# 2.	Setup

	Upload only the RobotService project in every task except Unit Tests.
	Do not modify the interfaces or their packages.
	Use strong cohesion and loose coupling.
	Use inheritance and the provided interfaces wherever possible:
	  This includes constructors, method parameters, and return types.
	Do not violate your interface implementations by adding more public methods in the concrete class than the interface has defined.
	Make sure you have no public fields anywhere.
	Exception messages and output messages can be found in the "Utilities" folder.
	For solving this problem use Visual Studio 2019, Visual Studio 2022 and netcoreapp 3.1, netcoreapp 6.0

# Task 1: Structure (50 points)

For this task’s evaluation logic in the methods isn’t included.

You are given some interfaces, and you have to implement their functionality in the correct classes.

There are 2 types of entities in the application: Supplement and Robot. 

There should also be SupplementRepository and RobotRepository, both implementing the IRepository interface.

## Supplement

A Supplement is a base class of any type of supplement and it should not be able to be instantiated.

## Data

	InterfaceStandard – int
		The compatibility standard that the Supplement supports.
		
	BatteryUsage - int
		The power that the Supplement will consume additionally when installed to a Robot.

## Constructor

A Supplement should take the following values upon initialization: 

	int interfaceStandard, int batteryUsage
