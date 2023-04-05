# 1.	Overview

You have to create a simple Hotel Booking application. It should be able to keep data about the available Rooms in different Hotels and to give information about the type and category rate of a hotel.

Guests should be able to check the room availability and bed capacity and to make new bookings. The application keeps data for all the bookings and the turnover of every hotel.

# 2.	Setup

	Upload only the BookingApp project in every problem except Unit Tests
	Do not modify the interfaces or their namespaces
	Use strong cohesion and loose coupling
	Use inheritance and the provided interfaces wherever possible
	This includes constructors, method parameters, and return types
	Do not violate your interface implementations by adding more public methods or properties in the concrete class than the interface has defined
	Make sure you have no public fields anywhere
	Exception messages and output messages can be found in the "Utilities" folder.
	For solving this problem use Visual Studio 2019, Visual Studio 2022 and netcoreapp 3.1.

# 3.	Task 1: Structure (50 points)

For this task’s evaluation logic in the methods isn’t included.

You are given 4 interfaces, and you have to implement their functionality in the correct classes.

There are 3 types of entities in the application: Room, Booking and Hotel. There should also be RoomRepository, BookingRepository and HotelRepository.

## Room

The Room is a base class of any type of room and it should not be able to be instantiated.

