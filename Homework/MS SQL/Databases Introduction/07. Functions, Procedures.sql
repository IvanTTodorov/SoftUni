USE [SoftUni]

GO 


--Task 01
CREATE PROCEDURE [usp_GetEmployeesSalaryAbove35000]
AS 
BEGIN 
	SELECT [FirstName], [LastName] 
	FROM [Employees]
	WHERE [Salary] > 35000
	
END

GO

EXEC [dbo].[usp_GetEmployeesSalaryAbove35000]


GO
--Task02 
CREATE PROC [usp_GetEmployeesSalaryAboveNumber] @minSalary DECIMAL(18,4)
AS 
BEGIN 
	SELECT [FirstName], [LastName]
	FROM [Employees]
	WHERE [Salary] >= @minSalary
END

GO

EXEC [dbo].[usp_GetEmployeesSalaryAboveNumber] 40000
EXEC [dbo].[usp_GetEmployeesSalaryAboveNumber] 48100 

--Task 03 
 
 GO 
 CREATE OR ALTER PROC [usp_GetTownsStartingWith] @StartingWith VARCHAR(50)
	AS 
	BEGIN 
		SELECT [Name] AS [Town]
		FROM Towns 
		WHERE LEFT([Name], LEN(@StartingWith)) = @StartingWith
	END
 GO 
 EXEC [dbo].[usp_GetTownsStartingWith] Be
  

  -- Task 04 
  GO  
	CREATE PROC [usp_GetEmployeesFromTown] @townName VARCHAR(50) 
	AS  
	BEGIN 
	SELECT [FirstName], [LastName]
	FROM [Employees] AS [e]
	LEFT JOIN Addresses AS [a] 
	ON [e].[AddressID] = [a].[AddressID] 
	LEFT JOIN Towns AS [t] 
	ON [a].[TownID] = [t].[TownID]  
	WHERE [t].[Name] = @townName 
	END 
GO  
		EXEC [dbo].[usp_GetEmployeesFromTown] Sofia
		EXEC [dbo].[usp_GetEmployeesFromTown] Plovdiv 

 
 -- Task 05  
  
  GO  
		CREATE FUNCTION [ufn_GetSalaryLevel] (@salary DECIMAL(18,4))  
		RETURNS VARCHAR(8)
	 AS 
		BEGIN  
				DECLARE @salaryLevel VARCHAR(8) 
				IF @salary < 30000   
			BEGIN  
				SET @salaryLevel = 'Low'
			END  
				IF @salary BETWEEN 30000 AND 50000 
			BEGIN 
				SET @salaryLevel = 'Average'
			END  
				IF @salary > 50000
			BEGIN 
				SET @salaryLevel = 'High'
			END  

			RETURN @salaryLevel
		END
  GO   

  SELECT [Salary],  
		[dbo].[ufn_GetSalaryLevel]([Salary]) 
		AS [Salary Level]
  FROM [Employees] 


  -- TASK 06  
 GO

 CREATE PROC [usp_EmployeesBySalaryLevel] @salaryLevel VARCHAR(8)
 AS 
 BEGIN 
	 SELECT [FirstName], [LastName] 
	 FROM [Employees]
	 WHERE [dbo].[ufn_GetSalaryLevel]([Salary]) = @salaryLevel
 END 

 GO

 EXEC [dbo].[usp_EmployeesBySalaryLevel] 'High'


 --Task 07 

 GO 
 CREATE PROC [usp_DeleteEmployeesFromDepartment] (@departmentId INT)  
 AS 
 BEGIN 
	DELETE FROM [Employees] 
	WHERE [DepartmentID] = @departmentId
	DELETE FROM [Departments]
	WHERE [DepartmentID] = @departmentId

	SELECT COUNT(*)
	FROM [Employees]
	WHERE [DepartmentID] = @departmentId
	END

 GO  


 -- Task 08  
 USE SoftUni
 GO  
 CREATE PROC [usp_DeleteEmployeesFromDepartment] (@departmentId INT) 
 AS  
 BEGIN  
	DELETE FROM [EmployeesProjects] 
		WHERE [EmployeeID] IN ( SELECT [EmployeeID] 
								FROM [Employees] 
								WHERE [DepartmentID] = @departmentId
		)  

		UPDATE [Employees] 
		SET[ManagerID] = NULL 
		WHERE [ManagerID] IN (SELECT [EmployeeID] 
							  FROM [Employees] 
							  WHERE [DepartmentID] = @departmentId
		)    

		ALTER TABLE [Departments] 
		ALTER COLUMN [ManagerID] INT  
		UPDATE [Departments] 
		SET [ManagerID] = NULL
		WHERE [ManagerID] IN (  
							SELECT [EmployeeID] 
							FROM [Employees] 
							 WHERE [DepartmentID] = @departmentId 
	    ) 

		DELETE FROM [Employees] 
		WHERE [DepartmentID] = @departmentId  

		DELETE FROM [Departments]
		WHERE [DepartmentID] = @departmentId   

		SELECT COUNT([EmployeeID]) 
		FROM [Employees]  
		WHERE [DepartmentID] = @departmentId

 END 

 EXEC [dbo].[usp_DeleteEmployeesFromDepartment] 2 
 GO  


 -- Task 09 

 USE [Diablo]

 GO 

 CREATE FUNCTION [ufn_CashInUsersGames] (@gameName NVARCHAR(50))
 RETURNS TABLE
 AS RETURN 
 (
 SELECT SUM([Cash]) AS [SumCash]
 FROM 
 (
 SELECT [ug].Cash,
 ROW_NUMBER() OVER(ORDER BY [Cash] DESC) AS [RowNumber]
 FROM [UsersGames] AS [ug]
 LEFT JOIN [Games] AS [g]
 ON [ug].GameId = [g].Id
 WHERE [g].Name = @gameName
 )
 AS [RowQuery]
 WHERE [RowNumber] % 2 = 1
 )

  GO

  SELECT * FROM [ufn_CashInUsersGames]('Love in a mist')


  USE [Bank]
  --Task 09 

  GO 
  CREATE PROCEDURE [usp_GetHoldersFullName]
  AS 
  BEGIN 
	SELECT CONCAT([FirstName], ' ', [LastName]) AS [Full Name]
	FROM [AccountHolders]
  END 
  GO

  EXEC [dbo].[usp_GetHoldersFullName]



  --Task 10 

  GO
  CREATE OR ALTER PROC [usp_GetHoldersWithBalanceHigherThan] @number DECIMAL(18,4)
  AS 
  BEGIN 
	SELECT [FirstName] AS [First Name], [LastName] AS [Last Name]
	FROM 
	(
	  SELECT [FirstName], [LastName], SUM([a].Balance) AS [Total sum] 
	  FROM [AccountHolders] AS [ah]
	 JOIN [Accounts] as [a]
	  ON [ah].Id = [a].AccountHolderId
	  GROUP BY [FirstName], [LastName]
	 )
	 AS [NewQuery]
	 WHERE [NewQuery].[Total sum] > @number  
	   ORDER BY [First Name], [Last Name]
  END 
  GO
  EXEC [dbo].[usp_GetHoldersWithBalanceHigherThan] 7000


  -- Task 11  
 
   GO 

CREATE FUNCTION ufn_CalculateFutureValue (@Sum DECIMAL(15,4),
@YearlyInterestRate FLOAT,
@NumberOfYears INT )
RETURNS DECIMAL(15,4)
BEGIN
    DECLARE @FutureValue DECIMAL(15,4);

    SET @FutureValue = @Sum * POWER((1 + @YearlyInterestRate), @NumberOfYears)
    
    RETURN @FutureValue
END  
	GO

	SELECT [FirstName], [dbo].ufn_CalculateFutureValue(a.Balance, 0.1, 5) AS [Balance in 5 years]
		FROM [AccountHolders] AS [ah]
			LEFT JOIN [Accounts] AS [a] 
				ON [ah].[Id] = [a].[Id]   


 
 -- Task 12  
 GO   
 CREATE PROC usp_CalculateFutureValueForAccount  @accountId INT, @interestRate DECIMAL (11,2)
 AS  
 BEGIN  
	SELECT [a].[Id], [ah].[FirstName], [ah].[LastName], [a].[Balance],
	[dbo].ufn_CalculateFutureValue(a.Balance, @interestRate, 5) AS [Balance in 5 years]
		FROM [AccountHolders] AS [ah]
			LEFT JOIN [Accounts] AS [a] 
				ON [ah].[Id] = [a].[Id]  
					WHERE [a].Id = @accountId
 END  

 EXEC [dbo].[usp_CalculateFutureValueForAccount] 1, 1 
  EXEC [dbo].[usp_CalculateFutureValueForAccount] 1, 0.2
   EXEC [dbo].[usp_CalculateFutureValueForAccount] 1, 0.03
 GO 
  




