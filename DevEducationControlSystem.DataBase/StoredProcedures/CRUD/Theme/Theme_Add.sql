CREATE PROCEDURE [dbo].[Theme_Add]
	@Name nvarchar(255)
AS
INSERT [Theme] VALUES (@Name)