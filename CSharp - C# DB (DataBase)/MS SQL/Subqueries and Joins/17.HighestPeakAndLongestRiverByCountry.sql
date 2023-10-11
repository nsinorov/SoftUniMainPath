SELECT TOP(5) 
      c.CountryName
     ,CASE WHEN p.Elevation = NULL
	  THEN NULL
	  ELSE MAX(p.Elevation)
	  END AS HighestPeakElevation

	  ,CASE WHEN r.[Length] = NULL
	  THEN NULL
	  ELSE MAX(r.[Length])
	  END AS LongestRiverLength
FROM Countries AS c
JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
JOIN Peaks AS p ON mc.MountainId = p.MountainId
JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
JOIN Rivers AS r ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC, c.CountryName