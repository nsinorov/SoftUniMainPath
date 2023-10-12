CREATE PROCEDURE usp_GetEmployeesFromTown(@townName VARCHAR(100))
AS
SELECT FirstName, LastName
FROM Employees AS e
JOIN Addresses AS a ON a.AddressID = e.AddressID
JOIN Towns AS t ON a.TownID = t.TownID
WHERE t.[Name] = @townName