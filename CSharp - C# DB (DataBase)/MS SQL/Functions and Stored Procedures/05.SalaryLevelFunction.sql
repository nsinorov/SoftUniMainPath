CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(10) AS
BEGIN
DECLARE @result VARCHAR(10) = 'Average';

IF(@salary < 30000)
BEGIN
  SET @result = 'Low'
END

ELSE IF(@salary > 50000)
BEGIN
  SET @result = 'High'
END

RETURN @result
END