CREATE PROC usp_GetHoldersWithBalanceHigherThan (@number DECIMAL(18,4))
AS
SELECT
	ah.FirstName,
	ah.LastName		
FROM AccountHolders AS ah
JOIN
(
	SELECT 
		AccountHolderId,
		SUM(Balance) AS TotalMoney
	FROM Accounts
	GROUP BY AccountHolderId
) AS a ON ah.Id = a.AccountHolderId

WHERE a.TotalMoney > @number
ORDER BY ah.FirstName, ah.LastName