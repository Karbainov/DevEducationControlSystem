CREATE PROCEDURE Course_Theme_Update
	@Id int,
	@CourseId int,
	@ThemeId int
AS
	UPDATE Course_Theme
	SET
		CourseId = @CourseId,
		ThemeID = @ThemeId
WHERE
	ID=@Id