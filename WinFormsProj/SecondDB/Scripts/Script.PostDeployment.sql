/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
Insert Into FirstTable
    (FirstName, Amount, LastName)
Values ('Ryan', 98.76, 'Hollinger');

Insert Into SecondTable
	(StreetAddress, City, State, ZipCode)
Values ('1003 Main St', 'Eden', 'NC', 27288);

Insert Into ThirdTable	
	(PhoneNum, FirstName, LastName, ZipCode)
Values (336-772-8934, 'Tad', 'Jones', 27288);
