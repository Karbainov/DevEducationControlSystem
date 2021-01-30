CREATE PROCEDURE [dbo].[User_Delete]
	@Id int
AS  
	DELETE FROM [dbo].[User] WHERE Id = @Id