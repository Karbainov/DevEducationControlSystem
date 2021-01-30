CREATE PROCEDURE [dbo].[Course_Theme_Delete]
	@Id int
AS
	DELETE FROM [dbo].[Course_Theme] WHERE Id=@Id