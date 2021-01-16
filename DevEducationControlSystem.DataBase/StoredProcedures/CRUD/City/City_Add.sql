CREATE PROCEDURE City_Add
	@ID int,	
	@Name nvarchar(100)
AS
INSERT [City] VALUES (@ID,
	@Name)
	