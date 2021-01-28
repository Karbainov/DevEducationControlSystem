CREATE PROCEDURE [dbo].[Lesson_Update]
	@Id int,
	@GroupId int,
	@Name nvarchar(100),
	@LessonDate date,
	@Comments nvarchar(1000)
AS
	UPDATE Lesson
	SET
		GroupId = @GroupId,
		Name = @Name,
		LessonDate = @LessonDate,
		Comments = @Comments
WHERE
	Id=@Id
