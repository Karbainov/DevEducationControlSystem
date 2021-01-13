CREATE PROCEDURE [dbo].[User_Role_Update]
	@Id int,
	@UserId int,
	@RoleId int
AS
	UPDATE User_Role 
	SET UserID=@UserId, 
	RoleId=@RoleId 
	WHERE ID=@Id