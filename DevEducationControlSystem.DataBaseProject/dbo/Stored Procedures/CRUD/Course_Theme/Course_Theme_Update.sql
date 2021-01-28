CREATE PROCEDURE [dbo].[Course_Theme_Update]
	@Id int,
	@CourseId int,
	@ThemeId int
AS
	UPDATE [dbo].[Course_Theme]
	SET
		CourseId = @CourseId,
		ThemeId = @ThemeId
WHERE
	Id=@Id