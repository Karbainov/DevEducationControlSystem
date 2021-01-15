CREATE PROCEDURE City_Add	
	@Name nvarchar(100)
AS
INSERT [City] VALUES (@Name)
	