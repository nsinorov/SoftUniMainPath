CREATE TABLE Deleted_Employees
(
	EmployeeId INT PRIMARY KEY IDENTITY, 
	FirstName VARCHAR(50), 
	LastName VARCHAR(50), 
	MiddleName VARCHAR(50), 
	JobTitle VARCHAR(50), 
	DepartmentId INT, 
	Salary DECIMAL(18, 2)
)
GO

-- Paste into Judge from here
CREATE TRIGGER tr_AddEntityToDeletedEmployeesTable
ON Employees FOR DELETE
AS
INSERT INTO Deleted_Employees
	SELECT		
		FirstName,
		LastName,
		MiddleName,
		JobTitle,
		DepartmentID,
		Salary
	FROM deleted
