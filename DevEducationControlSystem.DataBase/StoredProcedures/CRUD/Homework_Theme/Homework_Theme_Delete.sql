CREATE PROCEDURE [dbo].[Homework_Theme_Delete]  
	@ID int   
AS   
	DELETE FROM dbo.Homework_Theme
	WHERE ID = @ID
	