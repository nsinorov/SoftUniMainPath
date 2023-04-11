# 1.	Overview

We are in the year 2100. Technology is so advanced that robots are all around us. They are autonomous and do whatever you tell them to do. They use fluidization instead of charging to provide the energy they need, so robots need to be fed.

You are working on a robot service and you need to create a RobotService project to monitor the actions of a robot. 

Each service has a robot that requires different care. Your job is to add, feed and take care of the robot, as well as upgrade it with various supplements.

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

## Child Classes

There are two concrete types of Supplement:

###SpecializedArm

	A SpecializedArm has an InterfaceStandard of 10045 and a BatteryUsage of 10 000 mAh.

Note: The Constructor should take no values upon initialization.

### LaserRadar

	A LaserRadar has an InterfaceStandard of 20082 and a BatteryUsage of 5 000 mAh.

**Note: The Constructor should take no values upon initialization.**

## Robot

A Robot is a base class of any type of robot and it should not be able to be instantiated.

## Data

	Model – string
	
	If the Model is null or whitespace, throw a new ArgumentException with the message: 
	
		"Model cannot be null or empty."
		
	BatteryCapacity - int
		The maximum charging level of the Robot battery.
		The BatteryCapacity cannot drop below zero. If it does, throw a new ArgumentException with the message: 
		
		"Battery capacity cannot drop below zero."

	BatteryLevel – int
		The current level of the battery. When creating a new Robot, set its initial value, equal to the BatteryCapacity.
		
	ConvertionCapacityIndex - int
		The ability of the Robot to convert food into energy.
		
	InterfaceStandards – IReadOnlyCollection<int>
		A collection of all the supported connectivity standards by a specific Robot.

## Behavior

### void Eating(int minutes)

The Robot will be in fluidization mode, so it will convert the food into electrical energy. For every minute of eating, it will produce energy equal to the ConvertionCapacityIndex multiplied by the given minutes. 

	The Eating() method increases the Robot’s BatteryLevel, with the produced energy. 
	If the battery is fully charged (BatteryLevel = BatteryCapacity), the eating stops earlier. 

### void InstallSupplement(ISupplement supplement)

	The InstallSupplemet() method takes the given supplement’s InterfaceStandard and adds it to the list of InterfaceStandards of the Robot.
	Decreases the BatteryCapacity of the robot by the BatteryUsage of the supplement. 
	Decreases the BatteryLevel of the robot by the BatteryUsage of the supplement.

### bool ExecuteService(int consumedEnergy)	

The ExecuteService() method decreases the Robot’s BatteryLevel, with the given amount of consumed energy. 

	If the BatteryLevel is equal or greater than the given consumedEnergy, decrease the BatteryLevel with the given amount of consumedEnergy and return True.
	If the BatteryLevel is less than the given consumedEnergy, it means that it is NOT enough. Skip the execution and return False.

## Override ToString() method:

Override the existing method ToString() and modify it, so the returned string must be in the following format:

	"{robotTypeName} {Model}: 
	--Maximum battery capacity: {BatteryCapacity}
	--Current battery level: {BatteryLevel} 
	--Supplements installed: {standard1} {standard2}…/none"

Note: For best clarity see the output examples!

## Constructor

A Robot should take the following values upon initialization: 

	string model, int batteryCapacity, int conversionCapacityIndex

## Child Classes

There are several concrete types of Robot:

### DomesticAssistant

Has BatteryCapacity of 20 000 mAh.
The DomesticAssistant will produce a capacity of 2000 mAh of energy for every minute of eating - (convertionCapacityIndex = 2 000).

The Constructor of the DomesticAssistant should take the following parameters upon initialization:

	string model 

### IndustrialAssistant	

Has BatteryCapacity of 40 000 mAh.
The IndustrialAssistant will produce a capacity of 5000 mAh of energy for every minute of eating - (convertionCapacityIndex = 5 000).

The Constructor of the IndustrialAssistant should take the following parameters upon initialization:

	string model

##SupplementRepository

The SupplementRepository is an IRepository<ISupplement>. Collection for the supplements that are created in the application.
	
## Data
	
	A private field would be useful to store the items added.
	
## Behavior
	
### IReadOnlyCollection<ISupplement> Models()
	
	Returns all added items as a readonly collection.
	
### void AddNew(ISupplement supplement)
	
	Adds a new ISupplement to the SupplementRepository.
	
### bool RemoveByName(string typeName)
	
	Removes the first ISupplement from the collection, which has the same typeName as the given typeName. Returns true if the removal was successful, otherwise returns false.
	
### ISupplement FindByStandard(int interfaceStandard)
	
	Returns the first ISupplement supporting the given interface, if there is any. Otherwise, returns null.

## RobotRepository
	
The RobotRepository is an IRepository<IRobot>. Collection for the robots that are created in the application.
	
## Data
	
	A private field would be useful to store the items added.
	
## Behavior
	
###IReadOnlyCollection<IRobot> Models()
	
	Returns all added items as a readonly collection.
	
### void AddNew(IRobot robot)
	
	Adds a new IRobot to the RobotRepository.
	
### bool RemoveByName(string robotModel)
	
	Removes the first IRobot from the collection, which Model is the same as the given robotModel. Returns true if the deletion was successful, otherwise returns false.
	
### IRobot FindByStandard(int interfaceStandard)
	
	Returns the first IRobot supporting the given interface, if there is any. Otherwise, returns null.
