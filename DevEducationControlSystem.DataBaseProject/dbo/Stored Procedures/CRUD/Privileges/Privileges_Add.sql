CREATE PROCEDURE [dbo].[Privileges_Add]
	@name nvarchar(30)
AS 
INSERT [dbo].[Privileges] VALUES (@name)