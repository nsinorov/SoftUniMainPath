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
