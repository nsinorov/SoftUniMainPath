CREATE FUNCTION ufn_CashInUsersGames
(@gameName VARCHAR(50))
RETURNS TABLE
AS
	RETURN SELECT
	SUM(Cash) AS SumCash
	FROM
	(
		SELECT 
			u.GameId,		
			u.Cash,
			ROW_NUMBER() OVER(ORDER BY u.Cash DESC) AS RowNumber
		FROM UsersGames AS u
		JOIN Games AS g ON u.GameId = g.Id	
		WHERE g.[Name] = @gameName
		GROUP BY u.GameId, u.Cash
	) AS t
	WHERE t.RowNumber % 2 = 1