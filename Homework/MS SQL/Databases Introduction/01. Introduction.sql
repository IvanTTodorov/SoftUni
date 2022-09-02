CREATE DATABASE [Minions]  

CREATE TABLE [MinionsTable] (
	[Id] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL, 
	[Age] INT NOT NULL
	)
	

CREATE TABLE [Towns] (
[Id] INT PRIMARY KEY, 
[Name] NVARCHAR(70) NOT NULL
)

ALTER TABLE [MinionsTable] 
ADD [TownId] INT  FOREIGN KEY REFERENCES [Towns]([Id]) NOT NULL 

ALTER TABLE [MinionsTable]
ALTER COLUMN [Age] INT
 
 GO

 INSERT INTO [Towns]([Id], [Name])
	VALUES
	(1, 'Sofia'), 
	(2, 'Plovdiv'), 
	(3, 'Varna')


INSERT INTO[MinionsTable]([Id], [Name], [Age], [TownId])
	VALUES 
	(1, 'Kevin', 22, 1), 
	(2, 'Bob', 15, 3), 
	(3, 'Steward', NULL, 2)

GO

SELECT * FROM [Towns]
SELECT [Name], [Age]
FROM [MinionsTable]

GO


CREATE TABLE [People] (
	[Id] INT PRIMARY KEY IDENTITY, 
	[Name] NVARCHAR(200) NOT NULL,
	[Picture] VARBINARY(MAX),
	CHECK (DATALENGTH ([Picture]) <= 2000000), 
	[Height] DECIMAL(3, 2),
	[Weight] DECIMAL (5, 2),
	[Gender] CHAR(1) NOT NULL, 
	CHECK ([Gender] = 'm' OR [Gender] = 'f'),
	[Birthdate] DATE NOT NULL, 
	[Biography] NVARCHAR(MAX)
)

INSERT INTO [People]([Name], [Height], [Weight], [Gender], [Birthdate], [Biography])
VALUES 
('Pesho', 1.77, 45, 'm', '1966-12-12', 'Az sum Pesho'), 
('Maria', 1.17, NULL, 'f', '1999-12-12', 'Az sum Maria'), 
('Gosho', NULL, NULL, 'm', '1999-12-18', 'Az sum Gosho'), 
('Tisho', 1.50, 45.9, 'm', '2000-01-12', 'Az sum Tisho'), 
('Shisho', 1.34, 160, 'm', '1922-04-25', NULL)


SELECT *  FROM [People]

CREATE TABLE [Users] (
	[Id] BIGINT PRIMARY KEY IDENTITY,
	[Username] VARCHAR(30) UNIQUE NOT NULL, 
	[Password] VARCHAR(26) NOT NULL, 
	[ProfilePicture] VARBINARY(MAX),
	CHECK (DATALENGTH ([ProfilePicture]) <= 900000), 
	[LastLoginTime] DATETIME2,
	[IsDeleted] BIT NOT NULL
)

INSERT INTO Users([Username], [Password], [LastLoginTime], [IsDeleted])
VALUES 
('Pesho', 'kat54', NULL , 0), 
('Maria', 'kat54', NULL , 1), 
('Gosho',  'kat54', NULL , 0), 
('Tisho',  'kat54', NULL , 0), 
('Shisho', 'kat54', NULL , 0)

SELECT * FROM [Users] 

ALTER TABLE [Users] 
DROP CONSTRAINT [PK__Users__3214EC07B10F8EBA]  

ALTER TABLE [Users] 
ADD CONSTRAINT [PK_UsersCompositeIdUsername] PRIMARY KEY ([Id], [Username])






 


 
