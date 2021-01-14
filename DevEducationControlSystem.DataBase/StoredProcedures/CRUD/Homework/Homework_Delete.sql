CREATE PROCEDURE [dbo].[Homework_Delete]  
	@ID int   
AS   
	DELETE FROM dbo.Homework
	WHERE ID = @ID