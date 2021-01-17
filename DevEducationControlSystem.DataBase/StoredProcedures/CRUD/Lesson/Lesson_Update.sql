CREATE PROCEDURE [dbo].[Lesson_Update]
	@Id int,
	@GroupID int,
	@Name nvarchar(100),
	@LessonDate date,
	@Comments nvarchar(1000)
AS
	UPDATE Lesson
	SET
		GroupID = @GroupID,
		Name = @Name,
		LessonDate = @LessonDate,
		Comments = @Comments
WHERE
	Id=@Id
