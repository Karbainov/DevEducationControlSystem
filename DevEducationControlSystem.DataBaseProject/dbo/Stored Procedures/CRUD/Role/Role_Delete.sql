CREATE PROCEDURE [dbo].[Role_Delete]
	@Id int
AS
	DELETE FROM [dbo].[Role] WHERE Id=@Id
