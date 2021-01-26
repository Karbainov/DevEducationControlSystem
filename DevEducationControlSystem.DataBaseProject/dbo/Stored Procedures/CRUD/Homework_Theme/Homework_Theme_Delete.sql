CREATE PROCEDURE [dbo].[Homework_Theme_Delete]  
	@Id int   
AS   
	DELETE FROM dbo.Homework_Theme
	WHERE Id = @Id	