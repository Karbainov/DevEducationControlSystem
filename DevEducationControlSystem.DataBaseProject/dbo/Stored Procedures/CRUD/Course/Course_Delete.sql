CREATE PROCEDURE [dbo].[Course_Delete]  
	@Id int   
AS   
	DELETE FROM dbo.Course
	WHERE Id = @Id