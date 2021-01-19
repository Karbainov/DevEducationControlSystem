CREATE PROCEDURE [dbo].[Lesson_Add]
	@GroupID int,
	@Name nvarchar(100),
	@LessonDate date,
	@Comments nvarchar(1000)
AS
INSERT Lesson VALUES (@GroupID, @Name, @LessonDate, @Comments)