SELECT m.MountainRange, p.PeakName, p.Elevation FROM 
Mountains AS m
JOIN Peaks AS p
ON p.MountainID = m.Id
WHERE m.MountainRange = 'Rila'
ORDER BY p.Elevation DESC