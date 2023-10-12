CREATE DATABASE Boardgames
USE Boardgames

-- 01. DDL
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)


CREATE TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY,
	StreetName NVARCHAR(100) NOT NULL,
	StreetNumber INT NOT NULL,
	Town VARCHAR(30) NOT NULL,
	Country VARCHAR(50) NOT NULL,
	ZIP INT NOT NULL
)


CREATE TABLE Publishers
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30) NOT NULL UNIQUE,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id) NOT NULL,
	Website NVARCHAR(40) NOT NULL,
	Phone NVARCHAR(20) NOT NULL
)


CREATE TABLE PlayersRanges
(
	Id INT PRIMARY KEY IDENTITY,
	PlayersMin INT NOT NULL,
	PlayersMax INT NOT NULL
)


CREATE TABLE Boardgames
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
	YearPublished INT NOT NULL,
	Rating DECIMAL(18,2) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	PublisherId INT FOREIGN KEY REFERENCES Publishers(Id) NOT NULL,
	PlayersRangeId INT FOREIGN KEY REFERENCES PlayersRanges(Id) NOT NULL
)


CREATE TABLE Creators
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(30) NOT NULL,
)


CREATE TABLE CreatorsBoardgames
(
	CreatorId INT NOT NULL FOREIGN KEY REFERENCES Creators(Id),
    BoardgameId INT NOT NULL FOREIGN KEY REFERENCES Boardgames(Id),
    PRIMARY KEY (CreatorId, BoardgameId)
)


-- 02. Insert
INSERT INTO Boardgames([Name], YearPublished, Rating, CategoryId, PublisherId,PlayersRangeId)
VALUES
	('Deep Blue',         2019, 5.67, 1, 15, 7),
	('Paris',             2016, 9.78, 7, 1, 5),
	('Catan: Starfarers', 2021, 9.87, 7, 13, 6),
	('Bleeding Kansas',   2020, 3.25, 3, 7, 4),
	('One Small Step',    2019, 5.75, 5, 9, 2)


INSERT INTO Publishers([Name], AddressId, Website, Phone)
VALUES
	('Agman Games', 5, 'www.agmangames.com', '+16546135542'),
	('Amethyst Games', 7, 'www.amethystgames.com', '+15558889992'),
	('BattleBooks', 13, 'www.battlebooks.com', '+12345678907')



-- 03. Update
UPDATE PlayersRanges
SET PlayersMax += 1
WHERE PlayersMin = 2 AND PlayersMax = 2

UPDATE Boardgames
SET [Name] = CONCAT([Name], 'V2')
WHERE YearPublished >= 2020



-- 04. Delete
CREATE TABLE TempTableWithAddresses
(
    Id INT IDENTITY PRIMARY KEY,
    AddressId INT
)

INSERT INTO TempTableWithAddresses(AddressId)
SELECT Id
FROM Addresses
WHERE Town LIKE 'L%'

DECLARE @addressToRemove INT = 
(
	SELECT
    AddressId
    FROM TempTableWithAddresses
    WHERE Id = 1
)

DELETE FROM CreatorsBoardgames
WHERE BoardgameId IN
(
	SELECT b.Id
    FROM Boardgames AS b
    LEFT JOIN Publishers AS p ON p.Id = b.PublisherId
    WHERE p.AddressId IN (@addressToRemove)
)

DELETE FROM Boardgames
WHERE PublisherId IN
(
	SELECT Id
	FROM Publishers
	WHERE AddressId IN (@addressToRemove)
)

DELETE FROM Publishers
WHERE AddressId IN (@addressToRemove)

DELETE FROM Addresses
WHERE Id IN (@addressToRemove)



----- SECTION 3 - Queryng -----

-- 05. Boardgames by Year of Publication
SELECT [Name] , Rating FROM Boardgames
ORDER BY YearPublished, [Name] DESC


-- 06.Boardgames by Category
SELECT 
	b.Id,
	b.[Name],
	b.YearPublished,
	c.[Name] AS CategoryName
FROM Boardgames AS b
JOIN Categories AS c ON b.CategoryId = c.Id
WHERE c.[Name] IN ('Strategy Games', 'Wargames')
ORDER BY b.YearPublished DESC


-- 07. Creators without Boardgames
SELECT 
	c.Id,
	CONCAT(c.FirstName, ' ', c.LastName) AS CreatorName,
	c.Email
FROM Creators AS c
LEFT JOIN CreatorsBoardgames AS cb ON cb.CreatorId = c.Id
WHERE cb.BoardgameId IS NULL


-- 08. First 5 Boardgames
SELECT TOP(5) 
	b.[Name],
	b.Rating,
	c.[Name] AS CategoryName
FROM Boardgames AS b
JOIN Categories AS c ON b.CategoryId = c.Id
JOIN PlayersRanges AS pr ON b.PlayersRangeId = pr.Id
WHERE b.Rating > 7 AND b.[Name] LIKE '%a%' OR b.Rating > 7.5 AND pr.PlayersMin = 2 AND pr.PlayersMax = 5
ORDER BY b.[Name], b.Rating DESC


-- 09. Creators with Emails
SELECT 
	CONCAT(c.FirstName, ' ', c.LastName) AS FullName,
	c.Email,
	MAX(b.Rating) AS Rating
FROM Creators AS c
JOIN CreatorsBoardgames AS cb ON c.Id = cb.CreatorId
JOIN Boardgames AS b ON cb.BoardgameId = b.Id
WHERE c.Email LIKE '%.com'
GROUP BY c.FirstName, c.LastName, c.Email
ORDER BY FullName


-- 10. Creators by Rating
SELECT 
	c.LastName,
	CEILING(AVG(b.Rating)) AS AverageRaiting,
	p.[Name] AS PublisherName
FROM Creators AS c
JOIN CreatorsBoardgames AS cb ON cb.CreatorId = c.Id
JOIN Boardgames AS b ON b.Id = cb.BoardgameId
JOIN Publishers AS p ON p.Id = b.PublisherId
WHERE p.[Name] IN ('Stonemaier Games')
GROUP BY c.LastName, p.[Name]
ORDER BY AVG(b.Rating) DESC



----- SECTION 4 - Programmability -----

-- 11. Creator with Boardgames
CREATE FUNCTION udf_CreatorWithBoardgames(@name NVARCHAR(30))
RETURNS INT
BEGIN
    DECLARE @creatorId INT =
	(
        SELECT Id
        FROM Creators
        WHERE FirstName = @name
    )

    RETURN
	(
        SELECT COUNT(*)
        FROM CreatorsBoardgames
        WHERE CreatorId = @creatorId
    )

END
-- Don't submit that:
SELECT dbo.udf_CreatorWithBoardgames('Bruno')


-- 12. Search for Boardgame with Specific Category
CREATE OR ALTER PROCEDURE usp_SearchByCategory(@category VARCHAR(50))
AS
	SELECT
		b.[Name],
		b.YearPublished,
		b.Rating,
		c.[Name] AS CategoryName,
		p.[Name] AS PublisherName,
		CONCAT(pr.PlayersMin, ' ', 'people') AS MinPlayers,
		CONCAT(pr.PlayersMax, ' ', 'people') AS MaxPlayers
	FROM Boardgames AS b
	JOIN Categories AS c ON b.CategoryId = c.Id
	JOIN Publishers AS p ON b.PublisherId = P.Id
	JOIN PlayersRanges AS pr ON b.PlayersRangeId = pr.Id
	WHERE c.[Name] IN (@category)
	ORDER BY p.[Name], b.YearPublished DESC
	
-- Don't submit that:
EXEC usp_SearchByCategory 'Wargames'
