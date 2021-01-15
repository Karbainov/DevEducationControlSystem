CREATE PROCEDURE [dbo].[Privileges_Add]
	@Id int,
	@name nvarchar(30)
AS 
INSERT [dbo].[Privileges] VALUES (@name)