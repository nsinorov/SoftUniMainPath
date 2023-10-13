CREATE DATABASE CigarShop
USE CigarShop

-- SECTION 1 - DDL

-- 01.Create Tables
CREATE TABLE Sizes
(
	Id INT PRIMARY KEY IDENTITY,
	[Length] INT CHECK([Length] >= 10 AND [Length] <= 25) NOT NULL,
	RingRange DECIMAL(18,2) CHECK(RingRange >= 1.5 AND RingRange <= 7.5) NOT NULL,
)

CREATE TABLE Tastes
(
	Id INT PRIMARY KEY IDENTITY,
	TasteType VARCHAR(20) NOT NULL,
	TasteStrength VARCHAR(15) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL,
)

CREATE TABLE Brands
(
	Id INT PRIMARY KEY IDENTITY,
	BrandName VARCHAR(30) UNIQUE NOT NULL,
	BrandDescription VARCHAR(MAX)
)

CREATE TABLE Cigars
(
	Id INT PRIMARY KEY IDENTITY,
	CigarName VARCHAR(80) NOT NULL,
	BrandId INT FOREIGN KEY REFERENCES Brands(Id) NOT NULL,
	TastId INT FOREIGN KEY REFERENCES Tastes(Id) NOT NULL,
	SizeId INT FOREIGN KEY REFERENCES Sizes(Id) NOT NULL,
	PriceForSingleCigar MONEY NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
)

CREATE TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY,
	Town VARCHAR(30) NOT NULL,
	Country NVARCHAR(30) NOT NULL,
	Streat NVARCHAR(100) NOT NULL,
	ZIP VARCHAR(20) NOT NULL
)

CREATE TABLE Clients
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id) NOT NULL
)

CREATE TABLE ClientsCigars
(
	ClientId INT FOREIGN KEY REFERENCES Clients(Id) NOT NULL,
	CigarId INT FOREIGN KEY REFERENCES Cigars(Id) NOT NULL,
	PRIMARY KEY(ClientId, CigarId)
)


-- SECTION 2 - DML

-- 02.Insert
INSERT INTO Cigars(CigarName, BrandId, TastId, SizeId, PriceForSingleCigar, ImageURL)
VALUES
	('COHIBA ROBUSTO', 9, 1, 5, 15.50, 'cohiba-robusto-stick_18.jpg'),
	('COHIBA SIGLO I', 9, 1, 10, 410.00, 'cohiba-siglo-i-stick_12.jpg'),
	('HOYO DE MONTERREY LE HOYO DU MAIRE', 14, 5, 11, 7.50, 'hoyo-du-maire-stick_17.jpg'),
	('HOYO DE MONTERREY LE HOYO DE SAN JUAN', 14, 4, 15, 32.00, 'hoyo-de-san-juan-stick_20.jpg'),
	('TRINIDAD COLONIALES', 2, 3, 8, 85.21, 'trinidad-coloniales-stick_30.jpg')

INSERT INTO Addresses(Town, Country, Streat, ZIP)
VALUES
	('Sofia', 'Bulgaria', '18 Bul. Vasil levski', 1000),
	('Athens', 'Greece', '4342 McDonald Avenue', 10435),
	('Zagreb', 'Croatia', '4333 Lauren Drive', 10000)


-- 03.Update
UPDATE Cigars
SET PriceForSingleCigar *= 1.2
WHERE TastId = 1

UPDATE Brands
SET BrandDescription = 'New description'
WHERE BrandDescription IS NULL


-- 04.Delete
DELETE FROM Clients
WHERE AddressId IN (7, 8, 10, 23)

DELETE FROM Addresses
WHERE LEFT(Country, 1) = 'C'


-- SECTION 3 - Querying

-- 05.Cigars by Price
SELECT
	CigarName,
	PriceForSingleCigar,
	ImageURL
FROM Cigars
ORDER BY PriceForSingleCigar, CigarName DESC


-- 06.Cigars by Taste
SELECT
	c.Id,
	c.CigarName,
	c.PriceForSingleCigar,
	t.TasteType,
	t.TasteStrength
FROM Cigars AS c
JOIN Tastes AS t ON t.Id = c.TastId
WHERE t.TasteType IN ('Earthy', 'Woody')
ORDER BY c.PriceForSingleCigar DESC


--07.Clients without Cigars
SELECT
	cl.Id,
	CONCAT(cl.FirstName, ' ', cl.LastName) AS ClientName,
	cl.Email
FROM ClientsCigars AS cc
RIGHT JOIN Clients AS cl ON cl.Id = cc.ClientId
LEFT JOIN Cigars AS ci ON ci.Id = cc.CigarId
WHERE cc.CigarId IS NULL
ORDER BY ClientName


-- 08.First 5 Cigars
SELECT TOP(5)
	CigarName,
	PriceForSingleCigar,
	ImageURL
FROM Cigars AS c
JOIN Sizes AS s ON s.Id = c.SizeId
WHERE s.[Length] >= 12 AND (c.CigarName LIKE '%ci%' OR c.PriceForSingleCigar > 50) AND s.RingRange > 2.55
ORDER BY c.CigarName, c.PriceForSingleCigar DESC


-- 09.Clients with ZIP Codes
SELECT
	CONCAT(cl.FirstName, ' ', cl.LastName) AS FullName,
	a.Country,
	a.ZIP,
	CONCAT('$', MAX(ci.PriceForSingleCigar)) AS CigarPrice
FROM Clients AS cl
JOIN Addresses AS a ON a.Id = cl.AddressId
JOIN ClientsCigars AS cc ON cc.ClientId = cl.Id
JOIN Cigars AS ci ON ci.Id = cc.CigarId
WHERE ISNUMERIC(a.ZIP) = 1
GROUP BY CONCAT(cl.FirstName, ' ', cl.LastName), a.Country, a.ZIP
ORDER BY FullName


-- 10.Cigars by Size
SELECT
    c.LastName,
    AVG(s.[Length]) AS AverageLength,
    CEILING(AVG(s.RingRange)) AS AverageRingRange
FROM Clients AS c
JOIN ClientsCigars AS cc ON C.Id = cc.ClientId
JOIN Cigars AS cg ON cc.CigarId = cg.Id
JOIN Sizes AS s ON cg.SizeId = s.Id
GROUP BY c.LastName
ORDER BY AverageLength DESC



-- SECTION 4 - Programmability

-- 11.Client with Cigars
CREATE OR ALTER FUNCTION udf_ClientWithCigars(@name NVARCHAR(30))
RETURNS INT AS
BEGIN
	RETURN
	(
		SELECT
			COUNT(cg.Id)
		FROM Clients AS c
		JOIN ClientsCigars AS cc ON C.Id = cc.ClientId
		JOIN Cigars AS cg ON cc.CigarId = cg.Id
		WHERE c.FirstName = @name
	)
END

--Don't paste this into Judge, it is only to check the result:
SELECT dbo.udf_ClientWithCigars('Betty')


-- 12.Search for Cigar with Specific Taste
CREATE OR ALTER PROCEDURE usp_SearchByTaste(@taste VARCHAR(20))
AS
	SELECT
		c.CigarName,
		CONCAT('$', c.PriceForSingleCigar) AS Price,
		t.TasteType,
		b.BrandName,
		CONCAT(s.[Length], ' cm') AS CigarLength,
		CONCAT(s.RingRange, ' cm') AS CigarRingRange
	FROM Cigars AS c
	JOIN Tastes AS t ON t.Id = c.TastId
	JOIN Brands AS b ON b.Id = c.BrandId
	JOIN Sizes AS s ON s.Id = c.SizeId
	WHERE t.TasteType = @taste
	ORDER BY s.[Length], s.RingRange DESC

--Don't paste this into Judge, it is only to check the result:
EXEC usp_SearchByTaste 'Woody'