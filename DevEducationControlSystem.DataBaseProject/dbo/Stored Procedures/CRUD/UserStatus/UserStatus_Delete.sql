CREATE PROCEDURE [dbo].[UserStatus_Delete]
	@Id int 
AS 
	DELETE FROM UserStatus WHERE ID=@Id