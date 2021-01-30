CREATE PROCEDURE [dbo].[Lesson_Add]
	@GroupId int,
	@Name nvarchar(100),
	@LessonDate date,
	@Comments nvarchar(1000)
AS
INSERT Lesson VALUES (@GroupId, @Name, @LessonDate, @Comments)