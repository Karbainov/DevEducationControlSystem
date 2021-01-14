CREATE PROCEDURE [dbo].[User_Role_Add]
	@Id int,
	@UserId int ,
	@RoleId int
AS
	INSERT [dbo].[User_Role] VALUES (@Id, @UserId, @RoleId)