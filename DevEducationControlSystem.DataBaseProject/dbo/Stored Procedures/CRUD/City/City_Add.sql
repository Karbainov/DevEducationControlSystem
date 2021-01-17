CREATE PROCEDURE [dbo].[City_Add]	
	@Name nvarchar(100)
AS
INSERT [dbo].[City] VALUES (@Name)
	