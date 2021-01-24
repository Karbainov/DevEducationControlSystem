CREATE PROCEDURE [dbo].[Homework_Delete]  
	@Id int   
AS   
	DELETE FROM dbo.Homework
	WHERE Id = @Id