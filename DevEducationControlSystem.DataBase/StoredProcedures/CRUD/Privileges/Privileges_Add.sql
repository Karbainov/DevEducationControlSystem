CREATE PROCEDURE [dbo].[Privileges_Add]
	@name nvanchar(30)
AS 
INSERT [dbo].[Privileges] VALUES (@name)