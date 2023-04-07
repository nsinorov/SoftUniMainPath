# Overview

As we all love delicacies, today you were chosen to build a simple Christmas pastry shop software system. This system must have support for Delicacy, Cocktail and Booth.

The project will consist of model classes and a controller class, which manages the interaction between the delicacies, cocktails and booths.

# Setup

	Upload only the ChristmasPastryShop project in every task except Unit Tests.
	Do not modify the interfaces or their packages.
	Use strong cohesion and loose coupling.
	Use inheritance and the provided interfaces wherever possible.
    	This includes constructors, method parameters, and return types.
	Do not violate your interface implementations by adding more public methods in the concrete class than the interface has defined.
	Make sure you have no public fields anywhere.
	Exception messages and output messages can be found in the "Utilities" folder.
	For solving this problem use Visual Studio 2019, Visual Studio 2022 and netcoreapp 3.1

# Task 1: Structure (50 points)

For this task’s evaluation logic in the methods isn’t included.

You are given 4 interfaces, and you must implement their functionality in the correct classes.

There are 3 types of entities and 3 repositories in the application: Booth, Delicacy, Cocktail and a Repository(BoothRepository, DelicacyRepository, CocktailRepository) for each of them:

## Delicacy

Delicacy is a base class for any type of Delicacy, and it should not be able to be instantiated.

## Data

	Name - string
	
		If the name is null or whitespace, throw an ArgumentException with a message "Name cannot be null or whitespace!"
		
	Price - double 

## Override ToString() method:

Override the existing method ToString() and modify it, so the returned string must be in the following format:

	"{delicacyName} - {current price - formatted to the second decimal place} lv"

Note: Do not use "\r\n" for a new line.

## Constructor

The constructor of the Delicacy should take the following parameters upon initialization:

	string delicacyName, double price

## Child Classes

There are several concrete types of Delicacy:

### Gingerbread

	The Gingerbread has a constant value for gignerbreadPrice – 4.00

The constructor of the Gingerbread should take the following parameters upon initialization:

	string delicacyName

### Stolen

	The Stolen has a constant value for stolenPrice – 3.50

The constructor of the Stolen should take the following parameters upon initialization:

	string delicacyName

## Cocktail

Cocktail is a base class for any type of Cocktail and it should not be able to be instantiated.

## Data

	Name - string
		
		If the name is null or whitespace, throw an ArgumentException with message "Name cannot be null or whitespace!"
		
	Size - string
	
		Possible values: "Small", "Middle", "Large". this.Size will be validated later in the Controller class.
		
	Price - double 
	
		If the Size is set to "Large", the Price is set to be equal to the passed value
		If the Size is set to "Middle", the Price is equal to ⅔ of the passed value (example: ⅔ * 13.50 = 9.00)
		If the Size is set to "Small", the Price is equal to ⅓ of the passed value (example: ⅓ * 10.50 = 3.50)

### Override ToString() method:

Override the existing method ToString() and modify it, so the returned string must be in the following format:

	"{cocktailName} ({size}) - {cocktailPrice - formatted to the second decimal place} lv"

Note: Do not use "\r\n" for a new line.

## Constructor

A Cocktail should take the following values upon initialization:

	string cocktailName, string size, double price

## Child Classes

There are several concrete types of Cocktail:

### MulledWine

	The MulledWine has constant value for price of Large MulledWine – 13.50

The constructor of the MulledWine should take the following parameters upon initialization:

	string cocktailName, string size

### Hibernation

	The Hibernation has constant value for price of Large Hibernation - 10.50 

The constructor of the Hibernation should take the following parameters upon initialization:

	string cocktailName, string size

## Booth

## Data

	BoothId – int the booth number
	Capacity - int the booth capacity
	
		It can’t be less or equal to zero. In these cases, throw an ArgumentException with message: "Capacity has to be greater than 0!"
 
	DelicacyMenu – DelicacyRepository all available to order delicacies
	
	CocktailMenu – CocktailRepository all available to order cocktails
	
	CurrentBill – double, set initial value to zero and increase the CurrentBill after every successful order (UpdateCurrentBill method)
	
	Turnover – double, set initial value to zero the Turnover should be increased, after paying the CurrentBill upon leaving the Booth
	
		If no orders have been made to the specific Booth, return zero.
		
	IsReserved - boolean returns true if the Booth is reserved, otherwise returns false. Set its initial value to False.

## Behavior

### void UpdateCurrentBill(double amount)

	When ordering new item, adds the amount(itemPrice) to the CurrentBill.

### void Charge()

	Increases the Turnover with the amount of the CurrentBill and sets the CurrentBill to zero.

### void ChangeStatus()

Changes the IsReserved property:

	If its value is True, then sets it to False
	If its value is False, then sets it to True

### Override ToString() method:

Override the existing method ToString() and modify it, so the returned string must be in the following format:

	"Booth: {boothId}
	Capacity: {boothCapacity}
	Turnover: {turnoverAmount - formatted to the second decimal place} lv
	-Cocktail menu:
	--{cocktail1.ToString()}
	--{cocktail2.ToString()}
	…
	--{cocktailN.ToString()}
	-Delicacy menu:
	--{delicacy1.ToString()}
	--{delicacy2.ToString()}
	…
	--{delicacyN.ToString()}"

Note: Do not use "\r\n" for a new line.

## Constructor

A Booth should take the following values upon initialization:

	int boothId, int capacity

## DelicacyRepository

	The repository holds information about the delicacies.
