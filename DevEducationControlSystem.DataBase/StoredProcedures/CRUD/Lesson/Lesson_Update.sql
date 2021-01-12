CREATE PROCEDURE Lesson_Update
	@Id int,
	@GroupID int,
	@Name nvarchar(30),
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
	ID=@Id
