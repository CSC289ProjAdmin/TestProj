CREATE TABLE [dbo].[FirstTable]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[FirstName] varchar(50) not null,
	[Amount] money not null default 0, 
    [LastName ] NCHAR(10) NOT NULL
)
