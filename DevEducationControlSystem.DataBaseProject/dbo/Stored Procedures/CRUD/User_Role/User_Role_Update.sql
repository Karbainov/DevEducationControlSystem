CREATE PROCEDURE [dbo].[User_Role_Update]

	@UserId int,
	@RoleId int
AS
	UPDATE [dbo].[User_Role] 

	SET RoleId=@RoleId 

	WHERE dbo.[User_Role].UserId=@UserId