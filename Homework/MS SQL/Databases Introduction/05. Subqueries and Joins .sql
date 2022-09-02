USE [SoftUni] 

GO 

 
 --Task1 
 SELECT TOP(5) [EmployeeID], [JobTitle], [e].[AddressID], [a].[AddressText]
 FROM [Employees] AS [e] 
 LEFT JOIN [Addresses] AS [a]
 ON [e].[AddressID] = [a].[AddressID] 
 ORDER BY [a].[AddressID]
  
 --Task2 
 SELECT TOP(50) [FirstName], [LastName], [t].[Name] AS [Town], [a].[AddressText] 
 FROM [Employees] AS [e] 
 LEFT JOIN [Addresses] AS [a] 
 ON [e].[AddressID] = [a].[AddressID]
 LEFT JOIN [Towns] AS [t] 
 ON [a].[TownID]= [t].[TownID] 
 ORDER BY [FirstName], [LastName] 

 -- Task 3 
  SELECT  [EmployeeID], [FirstName], [LastName], [d].[Name] AS [DepartmentName]
  FROM [Employees]	AS [e] 
  LEFT JOIN [Departments] AS [d] 
  ON [e].[DepartmentID] = [d].[DepartmentID]  
  WHERE [e].[DepartmentID] = 3 
  ORDER BY [EmployeeID] 

 -- Task 4
SELECT TOP (5) [EmployeeID], [FirstName], [Salary], [d].[Name] AS [DepartmentName]
FROM [Employees] AS [e] 
LEFT JOIN [Departments] AS [d] 
  ON [e].[DepartmentID] = [d].[DepartmentID]   
  WHERE [e].[Salary] > 15000 
  ORDER BY [e].[DepartmentID] ASC
   
-- Task 5
  SELECT TOP(3) [e].[EmployeeID], [FirstName]
  FROM [Employees] AS [e] 
  LEFT JOIN [EmployeesProjects] AS [ep] 
  ON [e].[EmployeeID] = [ep].[EmployeeID]
  WHERE [ep].[ProjectID] IS NULL  
  ORDER BY [e].[EmployeeID] ASC 

-- Task 6 
 SELECT [FirstName], [LastName], [HireDate], [d].[Name] AS [DeptName] 
 FROM [Employees]  AS [e]
 INNER JOIN [Departments] AS [d] 
 ON [e].[DepartmentID] = [d].DepartmentID  
 WHERE DATEPART(YEAR,[HireDate]) BETWEEN 1999 AND 2022 AND  [d].[DepartmentID] IN (3,10) 
 ORDER BY HireDate ASC 
  

 -- Task 7  
 SELECT TOP(5) [ep].[EmployeeID], [FirstName], [Name] AS [ProjectName] 
 FROM [Employees] AS [e] 
 LEFT JOIN [EmployeesProjects] AS [ep] 
 ON [e].[EmployeeID] = [ep].[EmployeeID] 
 LEFT JOIN [Projects] AS [p] 
 ON [ep].ProjectID = [p].ProjectID  
 WHERE [p].[StartDate] > '08/13/2002' AND [p].[EndDate] IS NULL 
 ORDER BY [e].[EmployeeID] 

 -- Task 8  

 SELECT TOP(5) [ep].[EmployeeID], [FirstName], [Name] AS [ProjectName]
  FROM [Employees] AS [e]   
  LEFT JOIN [EmployeesProjects] AS [ep] 
 ON [e].[EmployeeID] = [ep].[EmployeeID] 
 LEFT JOIN [Projects] AS [p] 
 ON [ep].ProjectID = [p].ProjectID    
 AND [p].[StartDate] < '20050101'
 WHERE [e].EmployeeID = 24  

  -- Task 9
  
  SELECT [e].[EmployeeID], [e].[FirstName], [m].[EmployeeID] AS [ManagerID], [m].[FirstName] AS [ManagerName]
  FROM [Employees] AS [e]
  INNER JOIN [Employees] AS [m]
  ON [e].[ManagerID] = [m].[EmployeeID]
  WHERE [e].[ManagerID] IN (3, 7)
  ORDER BY [e].[EmployeeID] ASC
   

   -- Task 10
    
	SELECT TOP (50) [e].[EmployeeID], CONCAT ([e].[FirstName], ' ', [e].[LastName]) AS [EmployeeName],  
	CONCAT ([m].[FirstName],' ', [m].[LastName]) AS [ManagerName], 
	[d].[Name] AS [DepartmentName] 

	FROM [Employees] AS [e]	 
	INNER JOIN [Employees] AS [m] 
	ON [e].[ManagerID] = [m].[EmployeeID] 
	INNER JOIN [Departments] AS [d] 
	ON [e].[DepartmentID] = [d].DepartmentID 
	ORDER BY [e].[EmployeeID] ASC 

	USE [SoftUni]
	--Task 11  
	SELECT min(avg) AS [MinAverageSalary]
FROM (
       SELECT avg([Salary]) AS [avg]
       FROM Employees
       GROUP BY DepartmentID
     ) AS [AverageSalary]


	 --Task 12

	 USE [Geography]

	 GO 
	 SELECT [c].[CountryCode], [m].[MountainRange], [p].[PeakName], [p].[Elevation]
	 FROM [Countries] AS [c]
	 LEFT JOIN [MountainsCountries] AS [mc]
	 ON [c].CountryCode = [mc].CountryCode 
	LEFT JOIN [Mountains] AS [m]
	ON [mc].MountainId = [m].Id
	LEFT JOIN [Peaks] AS [p]
	ON [m].[Id] = [p].MountainId
	WHERE [c].CountryCode = 'BG' AND [p].Elevation > 2835
	ORDER BY [p].Elevation DESC 


	--Task 13 
	SELECT [c].[CountryCode], COUNT([mc].[MountainId]) AS [MountainRanges]
	FROM [Countries] AS [c]
	LEFT JOIN [MountainsCountries] AS [mc]
	ON [c].[CountryCode] = [mc].[CountryCode]
	WHERE [c].[CountryName] IN ('Bulgaria', 'Russia', 'United States')
	GROUP BY [c].[CountryCode]
	
	 
	--Task 14 
	SELECT TOP (5) [c].[CountryName], [r].[RiverName] 
	FROM [Countries] AS [c] 
	LEFT JOIN [CountriesRivers] AS [cr] 
	ON [c].[CountryCode] = [cr].[CountryCode]  
	LEFT JOIN [Rivers] AS [r] 
	ON [cr].[RiverId] = [r].[Id] 
	WHERE [c].[ContinentCode] = 'AF' 
	ORDER BY [c].[CountryName] ASC

	 
	 --Task 15    
	  SELECT [ContinentCode], [CurrencyCode], [CurrencyUsage]
	  FROM (
	  SELECT *, 
	  DENSE_RANK() OVER(PARTITION BY [ContinentCode] ORDER BY [CurrencyUsage] DESC)
	  AS [CurrencyRank]
	  FROM (
	  SELECT [cont].[ContinentCode], [cur].[CurrencyCode], 
	  COUNT ([c].CurrencyCode) AS [CurrencyUsage]
	  FROM [Continents]  AS [cont]
	  LEFT JOIN [Countries] AS [c] 
	  ON [cont].ContinentCode = [c].ContinentCode 
	  LEFT JOIN [Currencies] AS [cur] 
	  ON [c].CurrencyCode = [cur].CurrencyCode  
	  GROUP BY [cont].[ContinentCode], [cur].[CurrencyCode]  
	  ) AS [CurencyUsageQuery] 
	  WHERE [CurrencyUsage] > 1 
	  ) AS [CurrencyRankingQuery] 
	  WHERE [CurrencyRank] = 1
	    

	-- Task 16 

		SELECT 
	  COUNT ([c].[CountryCode]) AS [Count] 
	 FROM [Countries] AS [c]
	 LEFT JOIN [MountainsCountries] AS [mc]
	 ON [c].CountryCode = [mc].CountryCode 
	LEFT JOIN [Mountains] AS [m]
	ON [mc].MountainId = [m].Id 
	WHERE [m].[MountainRange] IS NULL 
	  

	 -- Task 17 

	  SELECT TOP (5) [c].[CountryName], 
	  MAX([p].[Elevation]) AS [HighestPeakElevation], 
	  MAX([r].[Length]) AS [LongestRiverLength]
	 FROM [Countries] AS [c]
	 LEFT JOIN [MountainsCountries] AS [mc]
	 ON [c].CountryCode = [mc].CountryCode 
	LEFT JOIN [Mountains] AS [m]
	ON [mc].MountainId = [m].Id
	LEFT JOIN [Peaks] AS [p]
	ON [m].[Id] = [p].MountainId  
	LEFT JOIN [CountriesRivers] AS [cr]
	ON [c].CountryCode = [cr].CountryCode 
	LEFT JOIN [Rivers] AS [r]
	ON [cr].[RiverID] = [r].Id 
	GROUP BY [c].[CountryName] 
	ORDER BY [HighestPeakElevation] DESC, [LongestRiverLength] DESC , [CountryName] ASC
	


	--Task 18
	SELECT TOP (5)[Country], 
	CASE 
		WHEN [PeakName] IS NULL THEN '(no highest peak)'
		ELSE [PeakName]
	END AS [Highest Peak Name],

	CASE
		WHEN [Elevation] IS NULL THEN '0'
		ELSE [Elevation]
	END AS [Highest Peak Elevation], 

	CASE 
		WHEN [Mountain] IS NULL THEN '(no mountain)'
		ELSE [Mountain]
	END AS [Mountain]

	FROM (
	SELECT [CountryName] AS [Country],
	[p].PeakName,
	[p].[Elevation],
	[m].[MountainRange] AS [Mountain],
	DENSE_RANK() OVER(PARTITION BY [c].[CountryName] ORDER BY [p].[Elevation] DESC) 
	AS [PeakRank] 
	FROM [Countries] AS [c]
	LEFT JOIN [MountainsCountries] AS [mc]
	 ON [c].CountryCode = [mc].CountryCode 
	LEFT JOIN [Mountains] AS [m]
	ON [mc].MountainId = [m].Id
	LEFT JOIN [Peaks] AS [p]
	ON [m].[Id] = [p].MountainId  
	) AS [PeakRankingQuery]
	WHERE [PeakRank] = 1
ORDER BY [Country], [Highest Peak Name]
	
