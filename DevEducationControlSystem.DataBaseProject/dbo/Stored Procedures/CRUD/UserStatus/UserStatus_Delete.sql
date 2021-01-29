CREATE PROCEDURE [dbo].[UserStatus_Delete]
	@Id int 
AS 
	DELETE FROM [dbo].[UserStatus] WHERE Id=@Id