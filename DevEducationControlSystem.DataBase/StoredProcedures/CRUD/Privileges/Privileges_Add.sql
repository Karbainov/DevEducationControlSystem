CREATE PROCEDURE [dbo].[Privileges_Add]
	@Id int,
	@name nvanchar(30)
AS 
INSERT [dbo].[Privileges] VALUES (@name)