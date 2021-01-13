CREATE PROCEDURE [dbo].[Course_Theme_Add]
	@CourseId int,
	@ThemeId int
AS
INSERT Course_Theme VALUES (@CourseId, @ThemeId)