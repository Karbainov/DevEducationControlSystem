CREATE PROCEDURE [dbo].[Lesson_Delete]
	@Id int
AS
	DELETE FROM Lesson WHERE ID=@Id
GO