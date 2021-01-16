CREATE PROCEDURE [dbo].[User_Role_Update]
	@Id int,
	@UserId int,
	@RoleId int
AS
	UPDATE [dbo].[User_Role] 
	SET UserId=@UserId, 
	RoleId=@RoleId 
	WHERE Id=@Id