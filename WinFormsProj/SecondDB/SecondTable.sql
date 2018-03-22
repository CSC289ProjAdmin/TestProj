CREATE TABLE [dbo].[SecondTable]
(
	[SecondId] INT NOT NULL PRIMARY KEY Identity,
	[StreetAddress] varchar(50) NOT NULL, 
    [City] NCHAR(10) NULL, 
    [State] NCHAR(10) NULL, 
    [ZipCode ] NUMERIC NOT NULL
)
