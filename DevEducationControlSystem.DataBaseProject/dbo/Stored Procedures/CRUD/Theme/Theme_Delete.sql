CREATE PROCEDURE [dbo].[Theme_Delete]
	@Id int
AS
	DELETE FROM [Theme] WHERE Id=@Id
