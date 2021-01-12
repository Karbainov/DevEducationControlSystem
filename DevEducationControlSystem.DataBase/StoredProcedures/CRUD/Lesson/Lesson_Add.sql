CREATE PROCEDURE Lesson_Add
	@GroupID int,
	@Name nvarchar(30),
	@LessonDate date,
	@Comments nvarchar(1000)
AS
INSERT Lesson VALUES (@GroupID, @Name, @LessonDate, @Comments)