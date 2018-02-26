CREATE TABLE [dbo].[TestTable]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [Name] VARCHAR(50) NOT NULL, 
    [Amount] MONEY NOT NULL DEFAULT 0
)
