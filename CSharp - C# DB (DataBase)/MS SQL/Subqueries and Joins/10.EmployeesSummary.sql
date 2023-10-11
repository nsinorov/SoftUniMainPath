SELECT TOP(50)
       e.EmployeeID
      ,CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeName
      ,CONCAT(m.FirstName, ' ', m.LastName) AS ManagerName
	  ,d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Employees AS m
	ON e.ManagerID = m.EmployeeID
JOIN Departments AS d
	ON e.DepartmentID = d.DepartmentID
ORDER BY EmployeeID