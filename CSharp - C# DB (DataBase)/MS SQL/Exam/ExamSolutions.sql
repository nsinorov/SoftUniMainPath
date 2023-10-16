CREATE DATABASE TouristAgency
USE TouristAgency

-- SECTION 1 - DDL

-- 01.Create Tables
CREATE TABLE Countries
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Destinations
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	CountryId INT FOREIGN KEY REFERENCES Countries(Id) NOT NULL
)

CREATE TABLE Rooms
(
	Id INT PRIMARY KEY IDENTITY,
	[Type] VARCHAR(40) NOT NULL,
	Price DECIMAL(18,2) NOT NULL,
	BedCount INT CHECK(BedCount > 0 AND BedCount <= 10) NOT NULL
)

CREATE TABLE Hotels
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	DestinationId INT FOREIGN KEY REFERENCES Destinations(Id) NOT NULL
)

CREATE TABLE Tourists
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(80) NOT NULL,
	PhoneNumber VARCHAR(20) NOT NULL,
	Email VARCHAR(80),
	CountryId INT FOREIGN KEY REFERENCES Countries(Id) NOT NULL
)

CREATE TABLE Bookings
(
	Id INT PRIMARY KEY IDENTITY,
	ArrivalDate DATETIME2 NOT NULL,
	DepartureDate DATETIME2 NOT NULL,
	AdultsCount INT CHECK(AdultsCount >= 1 AND AdultsCount <= 10) NOT NULL,
	ChildrenCount INT CHECK(ChildrenCount >= 0 AND ChildrenCount <= 9) NOT NULL,
	TouristId INT FOREIGN KEY REFERENCES Tourists(Id) NOT NULL,
	HotelId INT FOREIGN KEY REFERENCES Hotels(Id) NOT NULL,
	RoomId INT FOREIGN KEY REFERENCES Rooms(Id) NOT NULL
)

CREATE TABLE HotelsRooms
(
	HotelId INT FOREIGN KEY REFERENCES Hotels(Id) NOT NULL,
	RoomId INT FOREIGN KEY REFERENCES Rooms(Id) NOT NULL,
	PRIMARY KEY(HotelId, RoomId)
)


-- SECTION 2 - DML

-- 02.Insert
INSERT INTO Tourists([Name], PhoneNumber, Email, CountryId)
VALUES
	('John Rivers', '653-551-1555', 'john.rivers@example.com', 6),
	('Adeline Aglaé', '122-654-8726', 'adeline.aglae@example.com', 2),
	('Sergio Ramirez', '233-465-2876', 's.ramirez@example.com', 3),
	('Johan Müller', '322-876-9826', 'j.muller@example.com', 7),
	('Eden Smith', '551-874-2234', 'eden.smith@example.com', 6)

INSERT INTO Bookings(ArrivalDate, DepartureDate, AdultsCount, ChildrenCount, TouristId, HotelId, RoomId)
VALUES
	('2024-03-01', '2024-03-11', 1, 0, 21, 3, 5),
	('2023-12-28', '2024-01-06', 2, 1, 22, 13, 3),
	('2023-11-15', '2023-11-20', 1, 2, 23, 19, 7),
	('2023-12-05', '2023-12-09', 4, 0, 24, 6, 4),
	('2024-05-01', '2024-05-07', 6, 0, 25, 14, 6)


-- 03.Update
UPDATE Bookings
SET DepartureDate = DATEADD(DAY, 1, DepartureDate)
WHERE MONTH(DepartureDate) = 12

UPDATE Tourists
SET Email = NULL
WHERE [Name]  LIKE '%MA%'


-- 04.Delete
DELETE FROM Bookings 
WHERE TouristId IN (6, 16, 25)

DELETE FROM Tourists
WHERE [Name] LIKE '%Smith'



-- SECTION 3 - Querying

-- 05.Bookings by Price of Room and Arrival Date
SELECT
	FORMAT(b.ArrivalDate,'yyyy-MM-dd') AS ArrivalDate,
	b.AdultsCount,
	b.ChildrenCount
FROM Bookings AS b
JOIN Rooms AS r ON r.Id = b.RoomId
ORDER BY r.Price DESC, b.ArrivalDate


-- 06.Hotels by Count of Bookings
SELECT
	h.Id,
	h.[Name]
FROM HotelsRooms AS hr
JOIN Hotels AS h ON h.Id = hr.HotelId
JOIN Rooms AS r ON r.Id = hr.RoomId
JOIN Bookings  AS b ON b.HotelId = h.Id
WHERE r.[Type] = 'VIP Apartment'
GROUP BY h.Id, h.[Name]
ORDER BY COUNT(b.Id) DESC


-- 07.Tourists without Bookings
SELECT
	t.Id,
	t.[Name],
	t.PhoneNumber
FROM Tourists AS t
LEFT JOIN Bookings b ON t.Id = b.TouristId
WHERE b.Id IS NULL
ORDER BY t.[Name] ASC


-- 08.First 10 Bookings
SELECT TOP 10
    h.[Name] AS HotelName,
	d.[Name] AS DestinationName,
	c.[Name] AS CountryName
FROM Bookings b
JOIN Hotels h ON b.HotelId = h.Id
JOIN Destinations d ON h.DestinationId = d.Id
JOIN Countries c ON d.CountryId = c.Id
WHERE b.ArrivalDate < '2023-12-31' AND h.Id % 2 = 1
ORDER BY c.[Name], b.ArrivalDate


-- 09.Tourists booked in Hotels
SELECT
	h.[Name] AS HotelName,
	r.Price AS RoomPrice
FROM Tourists AS t
JOIN Bookings AS b ON b.TouristId = t.Id
JOIN Hotels AS h ON h.Id = b.HotelId
JOIN Rooms AS r ON r.Id = b.RoomId
WHERE RIGHT(t.[Name], 2) != 'EZ'
--GROUP BY h.[Name], r.Price
ORDER BY r.Price DESC


-- 10.Hotels by Turnover
SELECT h.[Name] AS HotelName, 
				SUM(r.Price * DATEDIFF(DAY, ArrivalDate, DepartureDate)) AS HotelRevenue
FROM Bookings AS b
JOIN Hotels AS h ON b.HotelId = h.Id
JOIN Rooms AS r ON b.RoomId = r.Id
GROUP BY h.[Name]
ORDER BY HotelRevenue DESC


-- SECTION 4 - Programmability

-- 11.Rooms with Tourists
CREATE OR ALTER FUNCTION udf_RoomsWithTourists(@roomType VARCHAR(40))
RETURNS INT
AS
BEGIN
    DECLARE @TotalTourists INT;

    SELECT @TotalTourists = SUM(b.AdultsCount + b.ChildrenCount)
    FROM Bookings b
    JOIN Rooms r ON b.RoomId = r.Id
    WHERE r.[Type] = @roomType

    IF @TotalTourists IS NULL
        SET @TotalTourists = 0

    RETURN @TotalTourists
END

--Don't paste this into Judge, it is only to check the result:
SELECT dbo.udf_RoomsWithTourists('Double Room')


-- 12.Search for Tourists from a Specific Country
CREATE OR ALTER PROCEDURE usp_SearchByCountry (@country NVARCHAR(50))
AS
BEGIN
    SELECT
        t.[Name],
        t.PhoneNumber,
        t.Email,
        COUNT(b.Id) AS CountOfBookings
    FROM Tourists t
    JOIN Bookings b ON t.Id = b.TouristId
    JOIN Countries c ON t.CountryId = c.Id
    WHERE c.[Name] = @country
    GROUP BY t.[Name], t.PhoneNumber, t.Email
    ORDER BY t.[Name] ASC, CountOfBookings DESC
END

--Don't paste this into Judge, it is only to check the result:
EXEC usp_SearchByCountry 'Greece'
