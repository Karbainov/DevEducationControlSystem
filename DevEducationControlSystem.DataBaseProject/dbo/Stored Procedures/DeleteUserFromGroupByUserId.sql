CREATE PROCEDURE [dbo].[DeleteUserFromGroupByUserId]
	@UserId int
AS
	DELETE FROM User_Group WHERE UserId=@UserId