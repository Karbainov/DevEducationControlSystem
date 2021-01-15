CREATE PROCEDURE [dbo].[User_Role_Delete]
	@Id int
AS
	DELETE FROM [dbo].[User_Role] WHERE Id=@Id