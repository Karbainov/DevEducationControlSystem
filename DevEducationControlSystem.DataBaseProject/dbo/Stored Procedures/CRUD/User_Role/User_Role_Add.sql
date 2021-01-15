CREATE PROCEDURE [dbo].[User_Role_Add]
	@UserId int,
	@RoleId int
AS
	INSERT [dbo].[User_Role] VALUES (@UserId, @RoleId)
