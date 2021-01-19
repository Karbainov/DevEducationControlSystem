CREATE PROCEDURE [dbo].[Lesson_Delete]
	@Id int
AS
	DELETE FROM Lesson WHERE Id=@Id
GO