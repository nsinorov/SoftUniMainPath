CREATE PROCEDURE usp_GetTownsStartingWith (@string VARCHAR(50))
AS
SELECT [Name] AS Town FROM Towns
WHERE SUBSTRING([Name], 1, LEN(@string)) = @string