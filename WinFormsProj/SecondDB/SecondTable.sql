CREATE TABLE [dbo].[SecondTable]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[StreetAddress] varchar(50), 
    [City] NCHAR(20) NULL, 
    [State] NVARCHAR(50) NULL, 
    [ZipCode ] INT NULL
)
