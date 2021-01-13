CREATE PROCEDURE [dbo].[Course_Delete]  
	@ID int   
AS   
	DELETE FROM dbo.Course
	WHERE ID = @ID