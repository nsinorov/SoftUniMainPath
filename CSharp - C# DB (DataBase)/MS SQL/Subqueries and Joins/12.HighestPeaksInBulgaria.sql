SELECT mc.CountryCode
      ,m.MountainRange
	  ,P.PeakName
	  ,p.Elevation
FROM Mountains AS m
JOIN Peaks AS p ON m.Id = p.MountainId
JOIN MountainsCountries AS mc ON mc.MountainId = m.Id
WHERE p.Elevation > 2835 AND mc.CountryCode = 'BG'
ORDER BY p.Elevation DESC