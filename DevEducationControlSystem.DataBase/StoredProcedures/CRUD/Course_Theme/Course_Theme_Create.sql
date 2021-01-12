CREATE PROCEDURE Course_Theme_Create
	@CourseId int,
	@ThemeId int
AS
INSERT Course_Theme VALUES (@CourseId, @ThemeId)