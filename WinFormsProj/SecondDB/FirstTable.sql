CREATE TABLE [dbo].[FirstTable]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[Name] varchar(50) not null,
	[Amount] money not null default 0
)
