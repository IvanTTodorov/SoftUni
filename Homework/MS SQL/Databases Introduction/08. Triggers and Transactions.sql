USE Bank 

 CREATE TABLE [Logs] 
 (  
		[LogId] INT PRIMARY KEY IDENTITY,
		[AccountId] INT FOREIGN KEY REFERENCES Accounts(Id), 
		[OldSum] DECIMAL (15,2), 
		[NewSum] DECIMAL (15,2) 
 ) 
  
  -- Task 01

 CREATE TRIGGER tr_InsertAccountInfo ON Accounts FOR UPDATE 
	AS  
	DECLARE @newSum DECIMAL (15,2) = (SELECT Balance FROM inserted) 
	DECLARE @oldSum DECIMAL (15,2) = (SELECT Balance FROM deleted) 
	DECLARE @accountId INT = (SELECT Id FROM inserted) 

	INSERT INTO Logs(AccountId, NewSum, OldSum) VALUES 
	(@accountId, @newSum, @oldSum) 

	 UPDATE Accounts  
	 SET Balance += 10 
	 WHERE Id = 2
	 
	 SELECT * 
	 FROM [Accounts]  
	 WHERE Id = 1 

	 SELECT *  
	 FROM [Logs] 

	  

	-- Task 02
	 
	 CREATE TABLE [NotificationEmails]  
	 (
	 [Id]  INT PRIMARY KEY IDENTITY ,
	 [Recipient] INT FOREIGN KEY REFERENCES Accounts(Id),  
	 [Subject] VARCHAR (50),
	 [Body] VARCHAR (MAX)
	 ) 

	 CREATE TRIGGER tr_LogEmail ON [Logs] FOR INSERT  
	 AS 
		 DECLARE  @Id INT = (SELECT TOP (1) [AccountId] FROM inserted)
		 DECLARE  @oldSum DECIMAL (15,2) = (SELECT [OldSum] FROM inserted) 
		 DECLARE  @newSum DECIMAL (15,2) = (SELECT [NewSum] FROM inserted) 
		 
		 INSERT INTO [NotificationEmails] (Recipient, Subject, Body) Values 
		 ( 
		 @Id, 
		 'Balance change for account: ' + CAST (@Id AS VARCHAR (20)),
		  'On ' + CONVERT(varchar(30), GETDATE(), 103) + ' your balance was changed from ' +  CAST(@oldSum 
		  AS VARCHAR(20)) + ' to ' + CAST(@newSum AS VARCHAR(20))
		 )

		 SELECT * 
		 FROM NotificationEmails 
		  
		UPDATE Accounts 
		SET Balance += 100
		WHERE ID = 1 


		--Task 03  
		ALTER PROC [usp_DepositMoney] @accountId INT,  @MoneyAmount DECIMAL (15,4)
	    AS  
			BEGIN TRANSACTION  

			DECLARE @account INT = (SELECT Id FROM Accounts WHERE Id = @accountId) 
			
		
			IF (@account IS NULL)   
			BEGIN   
				ROLLBACK 
				RAISERROR ('Invalid account id!', 16,1) 
				RETURN  
			END   

			IF (@MoneyAmount < 0) 
			BEGIN 
				ROLLBACK
				RAISERROR ('Negative amount!', 16,1) 
				RETURN
			END  

			

		UPDATE Accounts 
		SET Balance += @MoneyAmount 
		WHERE [Id] = @accountId 
		COMMIT
		 
		EXEC usp_DepositMoney 2, 1000
		SELECT *  
		FROM [Accounts] 
		WHERE Id = 2 


		-- Task 04  
		 
		ALTER PROCEDURE usp_WithdrawMoney @AccountId INT, @MoneyAmount DECIMAL (15,4) 
		AS  
		BEGIN TRANSACTION   

			DECLARE @account INT =  
						(SELECT [Id]  
						FROM [Accounts]  
						WHERE [Id] = @AccountId ) 
			DECLARE @userBalance DECIMAL (15,4) = (SELECT [Balance] FROM [Accounts] WHERE Id = @accountId)
					 
			IF (@account IS NULL)  
			BEGIN
				ROLLBACK  
				RAISERROR ('Invalid account id!', 16,1) 
				RETURN  
			END   

			IF (@MoneyAmount < 0) 
			BEGIN 
				ROLLBACK
				RAISERROR ('Negative amount!', 16,1) 
				RETURN
			END 

			IF (@userBalance - @MoneyAmount < 0) 
			BEGIN 
				ROLLBACK
				RAISERROR ('Insufficient funds!', 16,1) 
				RETURN
			END 

		UPDATE [Accounts]
		SET [Balance] -= @MoneyAmount
		WHERE [Id] = @AccountId
		COMMIT 

		EXEC [dbo].[usp_WithdrawMoney] 5, 100

		SELECT * FROM [Accounts] 
		WHERE [Id] = 5


		--Task 05 

		CREATE PROC [usp_TransferMoney] (@senderId INT, @receiverId INT , @amount DECIMAL (15,4))
		AS 
		BEGIN TRANSACTION 
		EXEC usp_WithdrawMoney @senderId, @amount
		EXEC usp_DepositMoney @receiverId, @amount
		COMMIT 

		SELECT * FROM Accounts WHERE Id = 1 OR Id = 2
		EXEC [usp_TransferMoney] 1,2, 1000

		

		--TASK 08

		USE [SoftUni]

		CREATE PROCEDURE usp_AssignProject (@employeeID int, @projectID int)
AS
BEGIN
  DECLARE @maxEmployeeProjectsCount int = 3;
  DECLARE @employeeProjectsCount int;

  BEGIN TRANSACTION
  INSERT INTO EmployeesProjects (EmployeeID, ProjectID) 
  VALUES (@employeeID, @projectID)

  SET @employeeProjectsCount = (
    SELECT COUNT(*)
    FROM EmployeesProjects
    WHERE EmployeeID = @employeeID
  )
  IF(@employeeProjectsCount > @maxEmployeeProjectsCount)
    BEGIN
      RAISERROR('The employee has too many projects!', 16, 1);
      ROLLBACK;
    END
  ELSE COMMIT
END


EXEC usp_AssignProject 2, 4

SELECT * FROM [EmployeesProjects]


--Task 09 
USE [SoftUni]

CREATE TABLE [Deleted_Employees] ( 
	[FirstName] NVARCHAR (50), 
	[LastName] NVARCHAR (50), 
	[MiddleName] NVARCHAR(10), 
	[JobTitle] VARCHAR(50), 
	[DepartmentID] INT, 
	[Salary] DECIMAL (18,2)
)
ALTER TABLE [Deleted_Employees]
ADD [EmployeeID] INT PRIMARY KEY 

	CREATE TRIGGER tr_DeletedEmployees ON Employees 
	FOR DELETE 
	AS 
	
	INSERT INTO Deleted_Employees (FirstName, LastName, MiddleName, JobTitle, DepatrmentId, Salary)

	SELECT  [FirstName], [LastName], [MiddleName], [JobTitle], [DepartmentID], [Salary] FROM deleted


	SELECT * FROM [Deleted_Employees]






		