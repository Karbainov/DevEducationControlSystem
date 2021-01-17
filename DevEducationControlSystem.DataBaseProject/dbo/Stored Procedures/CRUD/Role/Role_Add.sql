CREATE PROCEDURE [dbo].[Role_Add]
	@Name nvarchar(30)
AS
	INSERT [dbo].[Role] VALUES (@Name)
