CREATE PROCEDURE [dbo].[Role_Add]
	@Id int,
	@Name nvarchar(30)
AS
	INSERT [dbo].[Role] VALUES (@Id, @Name)
