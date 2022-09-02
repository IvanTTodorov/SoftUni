CREATE DATABASE [Bitbucket]

USE [Bitbucket]


--Task 01 
CREATE TABLE [Users] (
[Id] INT PRIMARY KEY IDENTITY, 
[Username] VARCHAR(30) NOT NULL, 
[Password] VARCHAR (30) NOT NULL, 
[Email] VARCHAR (50) NOT NULL
)

CREATE TABLE [Repositories](
[Id] INT PRIMARY KEY IDENTITY, 
[Name] VARCHAR(50) NOT NULL, 
)

CREATE TABLE [RepositoriesContributors] (
[RepositoryId] INT FOREIGN KEY REFERENCES [Repositories] ([Id]),
[ContributorId] INT FOREIGN KEY REFERENCES [Users] ([Id]),
PRIMARY KEY ([RepositoryId], [ContributorId])
)



CREATE TABLE [Issues] (
[Id] INT PRIMARY KEY IDENTITY,
[Title] VARCHAR(255) NOT NULL, 
[IssueStatus] VARCHAR(6) NOT NULL, 
[RepositoryId] INT FOREIGN KEY REFERENCES [Repositories] ([Id]) NOT NULL,
[AssigneeId] INT FOREIGN KEY REFERENCES [Users] ([Id]) NOT NULL

)

CREATE TABLE [Commits] (
[Id] INT PRIMARY KEY IDENTITY,
[Message] VARCHAR(255) NOT NULL, 
[IssueId] INT FOREIGN KEY REFERENCES [Issues]([Id]),
[RepositoryId] INT FOREIGN KEY REFERENCES [Repositories] ([Id]) NOT NULL,
[ContributorId] INT FOREIGN KEY REFERENCES [Users] ([Id]) NOT NULL

)

CREATE TABLE [Files] (
[Id] INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(100) NOT NULL, 
[Size] DECIMAL(18,2) NOT NULL, 
[ParentId] INT FOREIGN KEY REFERENCES [Files] ([Id]), 
[CommitId] INT FOREIGN KEY REFERENCES [Commits]([Id]) NOT NULL
)


--Task 2 

INSERT INTO [Files] ([Name], [Size], ParentId, CommitId) 
VALUES
('Trade.idk', 2598.0, 1 , 1), 
('menu.net', 9238.31, 2 , 2), 
('Administrate.soshy', 1246.93, 3, 3),
('Controller.php', 7353.15,	4,4),
('Find.java', 9957.86, 5, 5),
('Controller.json',	14034.87,	3,	6),
('Operate.xix',	7662.92, 7, 7)


INSERT INTO [Issues] ([Title], IssueStatus, RepositoryId, AssigneeId) 
VALUES 
('Critical Problem with HomeController.cs file', 'open', 1,	4),
('Typo fix in Judge.html',	'open',	4,	3),
('Implement documentation for UsersService.cs',	'closed',	8,	2),
('Unreachable code in Index.cs', 'open', 9,	8)

--Task 03
UPDATE [Issues]
SET [IssueStatus] = 'closed'
WHERE [AssigneeId] = 6

-- Task 04 

DELETE FROM [RepositoriesContributors]
WHERE [RepositoryId] = 3



DELETE FROM [Commits]
	WHERE [IssueId] IN (
				    SELECT [Id] FROM [Issues]
					WHERE [RepositoryId] = 3
						)

DELETE FROM [Issues] 
	WHERE  RepositoryId = 3 




	-- Task 05 
	SELECT [Id], [Message], [RepositoryId], [ContributorId]
	FROM [Commits]
	ORDER BY [Id] ASC, [Message] ASC, RepositoryId ASC, ContributorId ASC 

	--Task 06 
	SELECT [Id], [Name], [Size]
	FROM [Files]
	WHERE [Name] LIKE '%html%'
	AND [Size] > 1000
	ORDER BY [Size] DESC, [Id] ASC, [Name] ASC

	--Task 07 
	SELECT [i].[Id], CONCAT([u].Username, ' : ', [i].Title) AS [IssueAssignee]
	FROM [Issues] AS [i]
	 INNER JOIN [Users] AS [u]
	 ON [i].AssigneeId = [u].Id
	 ORDER BY [i].[Id] DESC, [i].[AssigneeId] asc


	 --Task 08 
	 SELECT [f].[Id], [f].[Name], CONCAT ([f].[Size], 'KB')
	 FROM [Files] AS [f]
	 LEFT JOIN [Files] AS [fl]
	 ON [f].Id = [fl].ParentId
	 WHERE [fl].Name IS NULL
	 ORDER BY [f].[Id], [f].[Name], [f].Size

	 --	Task 09 

	 SELECT TOP (5)[Id], [Name], [Commits] FROM 
	 (SELECT [r].Id, [r].[Name], COUNT([c].[Id]) AS [Commits] 
	 FROM [Repositories] AS [r]
	 LEFT JOIN [Commits] AS [c]
	 ON [r].Id = [c].RepositoryId
	 LEFT JOIN [RepositoriesContributors] as [rc] 
	 ON [rc].RepositoryId = [r].Id
	 GROUP BY [r].Id, [r].[Name]) 
	 AS [Query]
	 ORDER BY [Commits] DESC, [Id] ASC, [Name] asc 


	 --Task 10 
	 SELECT * 
	 FROM 
	 (
	 SELECT [u].Username, AVG([f].Size) AS [Size]  
	 FROM [Users] AS [u]
	 INNER JOIN [Commits] AS [c]
	 ON [u].Id = [c].ContributorId
	 INNER JOIN [Files] AS [f] 
	 ON [f].[CommitId] = [c].Id
	 GROUP BY [u].Username
	 ) AS [Query]
	 ORDER BY [Size] DESC, Username ASC 

	 --Task 11 
	 GO 
	 CREATE FUNCTION [udf_AllUserCommits] (@username VARCHAR(30))
	 RETURNS INT    
	 AS 
	 BEGIN 
		DECLARE @userId INT = (
							SELECT [Id] 
							FROM [Users]
							WHERE [Username] = @username
						)
		DECLARE @countCommits INT = (
										SELECT COUNT([Id])
										FROM [Commits]
										WHERE [ContributorId] = @userId
									)
		
		RETURN @countCommits; 

	 END
	 
	
	 GO
	 SELECT [dbo].[udf_AllUserCommits]('UnderSinduxrein');



	 --Task 12 
	 GO
	 CREATE OR ALTER PROC usp_SearchForFiles(@fileExtension VARCHAR (10)) 
	 AS 
	 BEGIN 
		SELECT [Id], [Name], [Size]
		FROM
		(
		SELECT [f].[Id], [f].[Name] AS [Name], 
		CONCAT([f].[Size], 'KB') AS [Size]
		FROM [Files] AS [f]
		) AS [QueryProc]

		WHERE [Name] LIKE CONCAT('%[.]', @fileExtension)
		ORDER BY [Id], [Name], [Size] DESC  
	 END 
	 GO

	 EXEC usp_SearchForFiles 'txt'
	 



